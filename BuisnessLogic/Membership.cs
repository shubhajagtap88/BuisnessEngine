using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class Membership : Ipayment
	{

		INotification _notification;
		public Membership(INotification notification)
		{
			_notification = notification;
		}
		public string HandleOrders()
		{
			_notification.send("Welcome!!, your membership is activated !!");
			return "Activated membership";
		}
	}
}
