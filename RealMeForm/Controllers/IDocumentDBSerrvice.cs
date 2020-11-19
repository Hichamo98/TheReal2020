using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using  RealMeForm.Models;

namespace TheRealMe.Controller
{
    interface IDocumentDBSerrvice
    {
        Task CreateDatabaseAsync(string databaseName);
        Task CreateDocumentCollectionAsync(string databaseName, string collectionName);
        Task <List<Evaluation> >GetStoreInfoAsync();
        Task SavePersonneDetailAsync(Evaluation p, bool isNewstudent);
        Task DeletePersonneAsync(string username);
    }
}
