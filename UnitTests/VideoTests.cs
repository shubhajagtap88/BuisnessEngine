using BuisnessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
	[TestClass]
	class VideoTests
	{
		[TestMethod]
		public void Video_AddSafetyBook()
		{
			var video = new Video();
			video.Name = "Learning to Ski";

			var result = video.IsAddSafetyBook();

			Assert.AreEqual(result, true);
		}

		public void Video_NotAddSafetyBook()
		{
			var video = new Video();
			video.Name = "Harr Potter";

			var result = video.IsAddSafetyBook();

			Assert.AreEqual(result, true);
		}
	}
}
