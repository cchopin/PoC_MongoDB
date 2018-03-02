using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;

namespace PoC_MongoDB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            IMongoClient client = new MongoClient("mongodb://localhost:27017/");
            IMongoDatabase database = client.GetDatabase("cbien");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("tarifs");
            
            

            var distinctAttributeNames = collection.Distinct(new StringFieldDefinition<BsonDocument, string>("categorie"), new BsonDocument()).ToList();

            foreach (var distinctItem in distinctAttributeNames)
            {
                ddlcategorie.Items.Add(distinctItem.ToString());
            }
        }
    }
}