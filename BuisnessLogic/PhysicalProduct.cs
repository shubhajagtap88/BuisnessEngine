using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class PhysicalProduct : Ipayment, ICommisionPayment
	{
		public int GenerateCommision(int price)
		{
			throw new NotImplementedException();
		}

		public string HandleOrders()
		{
			return "Generated a packing slip for shipping";
		}
	}
}
