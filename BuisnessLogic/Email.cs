using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class Email : INotification
	{
		public void send(string message)
		{
			Console.WriteLine(message);
		}
	}
}
