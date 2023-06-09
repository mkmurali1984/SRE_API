﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SRE_API.Models;

namespace SRE_API.Services
{
    public class PropertiesServices
    {
        private readonly IMongoCollection<PropertiesModel> propertiesCollection;

        public PropertiesServices(IOptions<DBSettings> dbSettings)
        {
            var propertiesConnection = new MongoClient(dbSettings.Value.ConnectionString);
            var propertiesdb = propertiesConnection.GetDatabase(dbSettings.Value.DatabaseName);
            propertiesCollection = propertiesdb.GetCollection<PropertiesModel>(dbSettings.Value.CollectionName);
        }

        public async Task<List<PropertiesModel>> GettheProperties()
        {
            return await propertiesCollection.Find(_ => true).ToListAsync();
        }

        public async Task InsertPropertiesDetails(PropertiesModel propertiesModel)
        {
            await propertiesCollection.InsertOneAsync(propertiesModel);
        }

        public PropertiesModel GetPropertyById(string id)
        {
            return propertiesCollection.Find(x => x.Id == id).FirstOrDefault();
        }

        public void updateProperties(string id, PropertiesModel propertiesModel)
        {
            propertiesCollection.ReplaceOne(x => x.Id == id, propertiesModel);
        }
    }
}
