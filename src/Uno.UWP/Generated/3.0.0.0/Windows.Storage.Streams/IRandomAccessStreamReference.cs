#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Streams
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IRandomAccessStreamReference 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IRandomAccessStreamWithContentType> OpenReadAsync();
		#endif
	}
}
