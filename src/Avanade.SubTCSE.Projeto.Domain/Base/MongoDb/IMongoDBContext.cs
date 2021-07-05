using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Domain.Base.MongoDb
{
    public interface IMongoDBContext
    {
        IMongoCollection<TEntity> GetCollection<TEntity>(string collection);
    }
}
