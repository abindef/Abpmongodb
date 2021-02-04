using System.Threading.Tasks;

namespace Alilimi.Mongodb.BookStore.Data
{
    public interface IBookStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
