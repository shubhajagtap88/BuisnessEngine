using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class Book : Ipayment, ICommisionPayment
	{
		public int GenerateCommision(int price)
		{
			throw new NotImplementedException();
		}

		public string HandleOrders()
		{
			return "Created a duplicate packing slip for the royalty department.";
		}
	}
}
