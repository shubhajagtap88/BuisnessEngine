using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class Upgrade : Ipayment
	{

		INotification _notification;
		public Upgrade(INotification notification)
		{
			_notification = notification;
		}
		public string HandleOrders()
		{
			_notification.send("Upgrade is done");
			return "Applied the upgrade";
		}
	}
}
