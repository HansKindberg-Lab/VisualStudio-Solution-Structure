using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetCore.HansKindberg.UnitTests
{
	[TestClass]
	public class FooTest
	{
		#region Methods

		[TestMethod]
		public void InternalValue_ShouldReturnTest()
		{
			using(var foo = new Foo())
			{
				Assert.AreEqual("Test", foo.InternalValue);
			}
		}

		[TestMethod]
		public void Value_ShouldReturnTest()
		{
			using(var foo = new Foo())
			{
				Assert.AreEqual("Test", foo.Value);
			}
		}

		#endregion
	}
}