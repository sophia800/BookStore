namespace BookStore.Presentation.Console
{
	using System;
	using System.Linq;
	using BookStore.Application;
	using BookStore.Domain.Models;
	using BookStore.Persistence.Services;
	using BookStore.Persistence.UnitOfWork;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Serialization;

	public static class Program
	{
		public static void Main ()
		{
			ConfigurationBoostraper ();

			var libraryApi = InitLibraryApi ();

			var libraryApiDecorator = new LibraryApiDecorator ( libraryApi );

			libraryApiDecorator.Examples ();

			var topBooks = libraryApiDecorator.GetTopBooks ();

			var topReaders = libraryApiDecorator.GetTopReaders ();

			var topReaderBooks = libraryApiDecorator.GetReadersOfMostPopularBook ();
		}

		public static LibraryApi InitLibraryApi ()
		{
			var data = new DataBaseManager ( "D:\\1_Sof\\BookStore\\Src\\BookStore.Presentation" );

			var unitOfWork = new InMemoryUnitOfWork ( data );

			return new LibraryApi ( unitOfWork );
		}

		private static void ConfigurationBoostraper ()
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
		}

		#region Test

		public static void Test ()
		{
			var inputNumbers = new[] { 2 , 3 , 4 , 5 , 6 };

			var colors =
				new[]
				{
					"Green" ,
					"Black" ,
					"Grey" ,
					"Pink" ,
					"Red" ,
					"Yellow"
				};

			var result1 =
				NumberAccumulation (
					accumulationFunc: ( number , accumulationResult ) => accumulationResult - number ,
					numbers: inputNumbers );

			DoSomething (
				someAction: number => Console.WriteLine ( number ) ,
				inputNumbers );

			IsRed (
				isSelectedColor: color => color == "Red" ,
				colors );
		}

		private static int NumberAccumulation ( Func<int , int , int> accumulationFunc , params int[] numbers )
		{
			int result = default;

			foreach ( var number in numbers )
				result = accumulationFunc ( number , result );

			return result;
		}

		public static void DoSomething ( Action<int> someAction , params int[] numbers )
		{
			foreach ( var number in numbers )
				someAction ( number );
		}

		public static void IsRed ( Predicate<string> isSelectedColor , params string[] colors )
		{
			foreach ( var color in colors )
			{
				if ( isSelectedColor ( color ) )
					Console.WriteLine ( $"Yeap its {color}" );
			}
		}

		#endregion Test
	}
}