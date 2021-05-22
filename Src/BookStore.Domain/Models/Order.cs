namespace BookStore.Domain.Models
{
	using System;
	using Interfaces;

	public sealed class Order : BaseModel
	{
		private readonly DateTime _dateTime = DateTime.Now;

		public string Date { get => _dateTime.ToString ( "yyyy-MM-dd" ); }

		public Book Book { get; set; }

		public Reader Reader { get; set; }
	}
}