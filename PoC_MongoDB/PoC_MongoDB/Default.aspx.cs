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
        IMongoClient client;
        IMongoDatabase database;        

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new MongoClient("mongodb://localhost:27017/");
            database = client.GetDatabase("cbien");
            IMongoCollection<BsonDocument> collectionCategorie = database.GetCollection<BsonDocument>("tarifs");
            
            var distinctAttributeNames = collectionCategorie.Distinct(new StringFieldDefinition<BsonDocument, string>("Categorie"), new BsonDocument()).ToList();

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
    }
}