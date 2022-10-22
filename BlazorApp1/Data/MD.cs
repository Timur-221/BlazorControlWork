using MongoDB.Bson;
using MongoDB.Driver;


namespace BlazorApp1.Data
{
    public class MD
    {
        private string connection = "mongodb://localhost:27017";
        private IMongoDatabase database;

        public MD()
        {
            var client = new MongoClient(connection);
            database = client.GetDatabase("User");
        }

        public void AddUser(User user)
        {
            var collection = database.GetCollection<User>("Useres");
            collection.InsertOne(user);

        }
    }
}
