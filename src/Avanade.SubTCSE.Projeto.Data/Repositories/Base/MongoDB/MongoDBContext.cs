using Avanade.SubTCSE.Projeto.Domain.Base.MongoDb;
using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            throw new System.NotImplementedException();
        }
    }
}
