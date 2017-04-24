using System;

namespace NetStandard.HansKindberg
{
	public class Foo : IDisposable
	{
		#region Properties

		protected internal virtual string InternalValue => "Test";
		public virtual string Value => "Test";

		#endregion

		#region Methods

		public void Dispose()
		{
			this.Dispose(true);

			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing) {}

		#endregion
	}
}