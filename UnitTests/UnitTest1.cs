using BuisnessLogic;
using BuisnessLogic.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ProcessOrder_PhysicalProduct()
		{
			var order = new ProcessOrder(new PhysicalProduct());

			var result = order.Process();

			Assert.AreEqual(result, "Generated a packing slip for shipping");
		}

		[TestMethod]
		public void ProcessOrder_Membership()
		{
			var order = new ProcessOrder(new Membership());

			var result = order.Process();

			Assert.AreEqual(result, "Activated membership");
		}

		[TestMethod]
		public void ProcessOrder_Books()
		{
			var order = new ProcessOrder(new Book());

			var result = order.Process();

			Assert.AreEqual(result, "Created a duplicate packing slip for the royalty department.");
		}


		[TestMethod]
		public void ProcessOrder_Upgrade()
		{
			var order = new ProcessOrder(new Upgrade());

			var result = order.Process();

			Assert.AreEqual(result, "Applied the upgrade");
		}

	}
}
