using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class PhysicalProduct : Ipayment
	{
		public string HandleOrders()
		{
			return "Generated a packing slip for shipping";
		}
	}
}
