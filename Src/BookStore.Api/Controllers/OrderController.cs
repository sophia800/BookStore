namespace BookStore.Api.Controllers
{
	using System.Threading.Tasks;
	using BookStore.Application.Services.OrderServices;
	using BookStore.Domain.Models;
	using Interfaces;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Logging;

	public sealed class OrderController : ExtendedController
	{
		private readonly ILogger<OrderController> _logger;

		private readonly OrderService _orderService;

		public OrderController ( ILogger<OrderController> logger , OrderService orderService )
		{
			_logger = logger;
			_orderService = orderService;
		}
	}
}