using BuisnessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
	[TestClass]
	class BookTests
	{
		[TestMethod]
		public void PhysicalProduct_GenerateCommision()
		{
			var order = new Book();
			//Assumption for Book agnet get 10% commision
			var result = order.GenerateCommision(100);

			Assert.AreEqual(result, 10);
		}
	}
}
