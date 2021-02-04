using Alilimi.Mongodb.BookStore.MongoDB;
using Xunit;

namespace Alilimi.Mongodb.BookStore
{
    [CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
    public class BookStoreApplicationCollection : BookStoreMongoDbCollectionFixtureBase
    {

    }
}
