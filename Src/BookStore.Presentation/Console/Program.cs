namespace BookStore.Presentation.Console
{
    using BookStore.Domain.Models;
    using BookStore.Domain.Models.Interfaces;
    using BookStore.Persistence.Services;
    using BookStore.Persistence.UnitOfWork;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;

    public static class Program
    {
        public static void Main ()
        {
            JsonConvert.DefaultSettings =
                () => new ()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver () ,
                    DefaultValueHandling = DefaultValueHandling.Include ,
                    TypeNameHandling = TypeNameHandling.None ,
                    NullValueHandling = NullValueHandling.Ignore ,
                    Formatting = Formatting.Indented ,
                    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
                };

            var data = new DataBaseManager ();

            var unitOfWork = new InMemoryUnitOfWork ( data );

            var libraryApi = new LibraryApi ( unitOfWork );

            foreach ( var author in libraryApi.Authors )
            {
                Console.WriteLine ( author.Id );
            }

            foreach ( var author in libraryApi.Readers )
            {
                Console.WriteLine ( author.Id );
            }

            foreach ( var author in libraryApi.Books )
            {
                Console.WriteLine ( author.Id );
            }

            foreach ( var author in libraryApi.Order )
            {
                Console.WriteLine ( author.Id );
            }
        }
    }
}