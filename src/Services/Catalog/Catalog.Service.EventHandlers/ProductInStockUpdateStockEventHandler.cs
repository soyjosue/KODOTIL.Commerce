using Catalog.Domain;
using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Service.EventHandlers
{
    public class ProductInStockUpdateStockEventHandler : INotificationHandler<ProductInStockUpdateStockCommand>
    {
        readonly ApplicationDbContext _context;
        readonly ILogger<ProductInStockUpdateStockEventHandler> _logger;
        public ProductInStockUpdateStockEventHandler(ApplicationDbContext context,
            ILogger<ProductInStockUpdateStockEventHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task Handle(ProductInStockUpdateStockCommand notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("--- ProductInStockUpdateStockCommand started");

            var products = notification.Items.Select(x => x.ProductId);
            var stocks = await _context.Stocks.Where(x => products.Contains(x.ProductId)).ToListAsync();

            _logger.LogInformation("--- Retrieve products from database");

            foreach (var item in notification.Items)
            {
                var entry = stocks.SingleOrDefault(x => x.ProductId == item.ProductId);

                if(item.Action == Common.Enums.productInStockAction.Substract)
                {
                    if(entry == null || item.Stock > entry.Stock)
                    {
                        var errorMessage = $"--- Product {entry.ProductId} - doesn't have enought stock";
                        _logger.LogError(errorMessage);
                        throw new Exception(errorMessage);
                    }

                    entry.Stock -= item.Stock;
                    _logger.LogInformation($"--- Product {entry.ProductId} - its stocks was subtracted - new stock {entry.Stock}");
                } else
                {
                    if (entry == null)
                    {
                        entry = new ProductInStock
                        {
                            ProductId = item.ProductId
                        };

                        await _context.AddAsync(entry);

                        _logger.LogInformation($"--- New stock record was created for {entry.ProductId} because didn´t exists before");
                    }

                    entry.Stock += item.Stock;
                    _logger.LogInformation($"--- Product {entry.ProductId} - its stocks was update - new stock {entry.Stock}");
                }
            }

            await _context.SaveChangesAsync();

            _logger.LogInformation("--- ProductInStockUpdateStockCommand ended");
        }
    }
}
