#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class StorageStreamTransaction : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.IRandomAccessStream Stream
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStream StorageStreamTransaction.Stream is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.StorageStreamTransaction.Stream.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncAction CommitAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction StorageStreamTransaction.CommitAsync() is not implemented in Uno.");
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.StorageStreamTransaction", "void StorageStreamTransaction.Dispose()");
		}
		#endif
		// Processing: System.IDisposable
	}
}