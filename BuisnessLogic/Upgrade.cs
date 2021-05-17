using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class Upgrade : Ipayment
	{
		public string HandleOrders()
		{
			return "Applied the upgrade";
		}
	}
}
