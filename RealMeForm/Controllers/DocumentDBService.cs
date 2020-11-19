using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using RealMeForm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
 

namespace TheRealMe.Controller
{
    class DocumentDBService : IDocumentDBSerrvice
    {
        public List<Evaluation> Items
        {
            get;
            private set;
        }
        DocumentClient client;
        Uri collectionLink;
        public DocumentDBService()
        {
            client = new DocumentClient(new Uri(Connection.EndpointUri), Connection.PrimaryKey);
            collectionLink = UriFactory.CreateDocumentCollectionUri(Connection.DatabaseName, "Evaluation");
        }
        public async Task CreateDatabaseAsync(string databaseName)
        {
            try
            {
                await client.CreateDatabaseIfNotExistsAsync(new Database
                {
                    Id = databaseName
                });
            }
            catch (DocumentClientException ex)
            {
                Debug.WriteLine("Error: ", ex.Message);
            }
        }

        public async Task CreateDocumentCollectionAsync(string databaseName, string collectionName)
        {
            try
            {
                await client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri(Connection.DatabaseName), new DocumentCollection
                {
                    Id = collectionName
                }, new RequestOptions
                {
                    OfferThroughput = 400
                });
            }
            catch (DocumentClientException ex)
            {
                Debug.WriteLine("Error: ", ex.Message);
            }
        }

        public async Task DeletePersonneAsync(string username)
        {
            try
            {
                await client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(Connection.DatabaseName,"Personne", username));
            }
            catch (DocumentClientException ex)
            {
                Debug.WriteLine("Error: ", ex.Message);
            }
        }
        async Task DeleteDocumentCollection()
        {
            try
            {
                await client.DeleteDocumentCollectionAsync(collectionLink);
            }
            catch (DocumentClientException ex)
            {
                Debug.WriteLine("Error: ", ex.Message);
            }
        }
        async Task DeleteDatabase()
        {
            try
            {
                await client.DeleteDatabaseAsync(UriFactory.CreateDatabaseUri(Connection.DatabaseName));
            }
            catch (DocumentClientException ex)
            {
                Debug.WriteLine("Error: ", ex.Message);
            }
        }

        public async Task<List<Evaluation>> GetStoreInfoAsync()
        {
            Items = new List<Evaluation>();
            try
            {
                var query = client.CreateDocumentQuery<Evaluation>(collectionLink).AsDocumentQuery();
                while (query.HasMoreResults)
                {
                    Items.AddRange(await query.ExecuteNextAsync<Evaluation>());
                }
            }
            catch (DocumentClientException ex)
            {
                Debug.WriteLine("Error: ", ex.Message);
            }
            return Items;
        }

        
        

        public async Task SavePersonneDetailAsync(Evaluation p, bool isNew)
        {
            try
            {
                if (isNew)
                {
                    await client.CreateDocumentAsync(collectionLink, p);
                }
                else
                {
                    await client.ReplaceDocumentAsync(UriFactory.CreateDocumentUri(Connection.DatabaseName,"Evaluation", ""), p);
                }
            }
            catch (DocumentClientException ex)
            {
                Debug.WriteLine("Error: ", ex.Message);
            }
        }

       
    }
    
}
