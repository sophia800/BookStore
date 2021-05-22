namespace BookStore.Persistence.Context
{
	using BookStore.Domain.Models;
	using Microsoft.EntityFrameworkCore;

	public sealed class LibraryContext : DbContext
	{
		public DbSet<Order> Orders { get; set; }

		public DbSet<Book> Books { get; set; }

		public DbSet<Author> Authors { get; set; }

		public DbSet<Reader> Readers { get; set; }

		protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder ) =>
			optionsBuilder.UseNpgsql ( "Host='ec2-99-80-200-225.eu-west-1.compute.amazonaws.com';Database=d63l5m1inlom38;Username=xwvjnjyyscuotm;Password='9b1f7309f2b527cffdbfa61a45e0c8293bd57030a2027ff5d130a7caa4c40e7d';SslMode=Require;Trust Server Certificate=true" );
	}
}