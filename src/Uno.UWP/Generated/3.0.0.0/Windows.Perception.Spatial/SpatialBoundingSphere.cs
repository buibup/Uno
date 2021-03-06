#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.Spatial
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct SpatialBoundingSphere 
	{
		// Forced skipping of method Windows.Perception.Spatial.SpatialBoundingSphere.SpatialBoundingSphere()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::System.Numerics.Vector3 Center;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  float Radius;
		#endif
	}
}
