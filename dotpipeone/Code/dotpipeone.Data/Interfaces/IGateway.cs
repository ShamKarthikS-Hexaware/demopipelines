using MongoDB.Driver;

namespace dotpipeone.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
