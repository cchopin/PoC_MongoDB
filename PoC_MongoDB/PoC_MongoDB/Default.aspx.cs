using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PoC_MongoDB
{
    public partial class Default : System.Web.UI.Page
    {
<<<<<<< HEAD
        IMongoClient client;
        IMongoDatabase database;        

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new MongoClient("mongodb://localhost:27017/");
            database = client.GetDatabase("cbien");
            IMongoCollection<BsonDocument> collectionCategorie = database.GetCollection<BsonDocument>("tarifs");
            
            var distinctAttributeNames = collectionCategorie.Distinct(new StringFieldDefinition<BsonDocument, string>("Categorie"), new BsonDocument()).ToList();
=======
        static IMongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase database = client.GetDatabase("cbien");

        protected void Page_Load(object sender, EventArgs e)
        {            
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("tarifs");
          
            var distinctAttributeNames = collection.Distinct(new StringFieldDefinition<BsonDocument, string>("Categorie"), new BsonDocument()).ToList();
>>>>>>> 23baa8b5f478089e04bd1b4a780d1603219a63d5

            foreach (var distinctItem in distinctAttributeNames)
            {
                ddlcategorie.Items.Add(distinctItem.ToString());
            }

        }

        protected void ddlcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tarifs tarif = new Tarifs();

            var userCollection = database.GetCollection<Tarifs>("tarifs");
            var users = userCollection.Find().SetFields("a", "b");






        }

        protected async void ddlcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("tarifs");

            BsonDocument filter = new BsonDocument();
            BsonDocument projection = new BsonDocument();
            projection.Add("SousCategorie.GarantieTarif.GarantieCode", 1);

            var options = new FindOptions<BsonDocument>()
            {
                Projection = projection
            };

            using (var cursor = await collection.FindAsync(filter, options))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    int i = 0;
                    foreach (BsonDocument document in batch)
                    {
                        txtValeur.Text += document[1][0][0][i][0].AsBsonValue.ToString() + " ";
                        i++;
                    }
                }
            }
        }
    }
}