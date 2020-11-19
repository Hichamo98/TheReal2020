using RealMeForm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheRealMe.Controller
{
    class PersonManager
    {
        IDocumentDBSerrvice documentDBService;
        public PersonManager(IDocumentDBSerrvice service)
        {
            documentDBService = service;
        }
        public Task CreateDatabase(string databaseName)
        {
            return documentDBService.CreateDatabaseAsync(databaseName);
        }
        public Task CreateDocumentCollection(string databaseName, string collectionName)
        {
            return documentDBService.CreateDocumentCollectionAsync(databaseName, collectionName);
        }
        public async Task<List<Evaluation>> GetStoreInfoAsync()
        {
            return await documentDBService.GetStoreInfoAsync();
        }
        public Task SavePersonneAsync(Evaluation personne, bool isNewItem)
        {
            return documentDBService.SavePersonneDetailAsync(personne, isNewItem);
        }
        public Task DeleteStudentAsync(Evaluation personne)
        {
            return documentDBService.DeletePersonneAsync("");
        }
    }
}
