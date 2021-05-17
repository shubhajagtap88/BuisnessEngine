using BuisnessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
	[TestClass]
	public class PhysicalProductTests
	{
		[TestMethod]
		public void PhysicalProduct_GenerateCommision()
		{
			var order = new PhysicalProduct();
			//Assumption for physical prodcut agnet get 5% commision
			var result = order.GenerateCommision(100);

			Assert.AreEqual(result, 5);
		}
	}
}
