using BuisnessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BuisnessLogic
{
	class Program
	{
		static void Main(string[] args)
		{
			var services = ConfigureServices();
			var serviceProvider = services.BuildServiceProvider();
			serviceProvider.GetService<ProcessOrder>().Process();
		}
		private static IServiceCollection ConfigureServices()
		{
			IServiceCollection services = new ServiceCollection();
			services.AddTransient<INotification, Email>();
			services.AddTransient<Ipayment, Membership>();
			

			services.AddTransient<ProcessOrder>();
			return services;
		}
	}
}
