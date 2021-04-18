namespace BookStore.Domain.Models.Common.Extensions
{
	using System;
	using Interfaces;

	public static class ModelExtensions
	{
		public static Guid GenerateGuid ( this IModel _ ) =>
			Guid.NewGuid ();
	}
}