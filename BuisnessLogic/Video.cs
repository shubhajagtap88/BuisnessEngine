using BuisnessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
	public class Video : Ipayment
	{
		public string Name { get; set; }
List<string> SafetyRequiredVideos = new List<string>{ "Learning to Ski", "Swiming" };
		public string HandleOrders()
		{
			throw new NotImplementedException();
		}

		public Boolean IsAddSafetyBook()
		{
			if (SafetyRequiredVideos.Contains(Name)) return true;
			return false;
		}
	}
}
