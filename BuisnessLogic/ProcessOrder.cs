using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class ProcessOrder
	{
		Ipayment _ipayment;
		public ProcessOrder(Ipayment ipayment)
		{
			_ipayment = ipayment;
		}

		public string Process()
		{
			return _ipayment.HandleOrders();

		}
	}
}
