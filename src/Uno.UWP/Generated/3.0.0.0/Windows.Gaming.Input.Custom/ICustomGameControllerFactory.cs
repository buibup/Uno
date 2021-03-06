#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input.Custom
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICustomGameControllerFactory 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		object CreateGameController( global::Windows.Gaming.Input.Custom.IGameControllerProvider provider);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void OnGameControllerAdded( global::Windows.Gaming.Input.IGameController value);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void OnGameControllerRemoved( global::Windows.Gaming.Input.IGameController value);
		#endif
	}
}
