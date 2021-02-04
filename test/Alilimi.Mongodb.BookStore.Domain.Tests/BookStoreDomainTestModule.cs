using Alilimi.Mongodb.BookStore.MongoDB;
using Volo.Abp.Modularity;

namespace Alilimi.Mongodb.BookStore
{
    [DependsOn(
        typeof(BookStoreMongoDbTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}