using Catalog.api.Entities;
using MongoDB.Driver;

namespace Catalog.api.Data.Interfaces
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
