#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct ProfileUsage 
	{
		// Forced skipping of method Windows.Networking.NetworkOperators.ProfileUsage.ProfileUsage()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint UsageInMegabytes;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::System.DateTimeOffset LastSyncTime;
		#endif
	}
}
