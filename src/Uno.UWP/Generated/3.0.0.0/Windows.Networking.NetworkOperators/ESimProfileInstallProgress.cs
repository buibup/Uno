#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct ESimProfileInstallProgress 
	{
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimProfileInstallProgress.ESimProfileInstallProgress()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int TotalSizeInBytes;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int InstalledSizeInBytes;
		#endif
	}
}