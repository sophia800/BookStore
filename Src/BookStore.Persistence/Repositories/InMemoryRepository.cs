namespace BookStore.Persistence.Repositories
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Domain.Models.Interfaces;
    using System.IO;
    using Newtonsoft.Json;

    public sealed class InMemoryRepository<TModel> : IRepository<TModel>
        where TModel : IModel
    {
        public string TableFilePath { get; }

        public InMemoryRepository ( string tableFilePath )
        {
            if ( string.IsNullOrEmpty ( tableFilePath ) )
                throw new ArgumentNullException ( nameof ( tableFilePath ) , "Table file path is null" );

            TableFilePath = tableFilePath;
        }

        public HashSet<TModel> GetAll ()
        {
            var modelsTextContent = File.ReadAllText ( TableFilePath );

            return JsonConvert.DeserializeObject<HashSet<TModel>> ( modelsTextContent );
        }
    }
}