namespace BookStore.Domain.Models
{
	using System;
	using Interfaces;

	public class Order : IModel
	{
		private readonly DateTime _dateTime = DateTime.Now;

		public Guid Id { set; get; } = Guid.NewGuid ();

		public string Date { get => _dateTime.ToString ( "yyyy-MM-dd" ); }

		public Book Book { get; set; }

		public Reader Reader { get; set; }
	}
}