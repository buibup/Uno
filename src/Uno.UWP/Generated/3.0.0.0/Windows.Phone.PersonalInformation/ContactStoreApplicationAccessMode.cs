#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.PersonalInformation
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum ContactStoreApplicationAccessMode 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		LimitedReadOnly,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ReadOnly,
		#endif
	}
	#endif
}
