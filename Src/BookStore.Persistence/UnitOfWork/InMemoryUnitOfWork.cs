namespace BookStore.Persistence.UnitOfWork
{
    using System;
    using System.Threading.Tasks;
    using Repositories.Interfaces;
    using Interfaces;
    using Domain.Models.Interfaces;
    using Services;
    using System.IO;
    using Repositories;
    using BookStore.Domain.Models;
    using Newtonsoft.Json;

    public sealed class InMemoryUnitOfWork : IUnitOfWork
    {
        private readonly DataBaseManager _dataBaseManager;

        public InMemoryUnitOfWork ( DataBaseManager dataBaseManager )
        {
            _dataBaseManager = dataBaseManager;
        }

        public IRepository<TModel> Repository<TModel> ()
           where TModel : IModel
        {
            _dataBaseManager.EnsureDataBaseFilesCreated ( typeof ( TModel ) );

            var tableFilePath = FormTableFilePath ( typeof ( TModel ) );

            return Activator.CreateInstance ( typeof ( InMemoryRepository<TModel> ) , tableFilePath )
                as InMemoryRepository<TModel>;
        }

        private string FormTableFilePath ( Type modelType )
        {
            var tableName = $"{modelType.Name}.json";

            return Path.Combine ( _dataBaseManager.DbDirectoryPath , tableName );
        }

        public Task CommitAsync ()
        {
            var authors = new []
           {
                new Author
                {
                    Name = "test" ,
                    Biography = "tew"
                }
            };

            var serilizedAuthors =
                JsonConvert.SerializeObject ( authors );

            var pathToAuthorFileTable = Path.Combine ( _dataBaseManager.DbDirectoryPath , "Author.json" );

            File.WriteAllText ( pathToAuthorFileTable , serilizedAuthors );

            return Task.CompletedTask;

            var books = new []
           {
                new Book
                {
                    Title = "test" ,
                    Author =
                }
            };

            var serilizedAuthors =
                JsonConvert.SerializeObject ( books );

            var pathToAuthorFileTable = Path.Combine ( _dataBaseManager.DbDirectoryPath , "Book.json" );

            File.WriteAllText ( pathToBookFileTable , serilizedBooks );

            return Task.CompletedTask;
        }
    }
}