using Microsoft.ReactNative.Managed;

namespace NativeModuleSample
{
    public sealed class ReactPackageProvider : Microsoft.ReactNative.IReactPackageProvider
    {
        public void CreatePackage(Microsoft.ReactNative.IReactPackageBuilder packageBuilder)
        {
            packageBuilder.AddAttributedModules();
        }
    }
}
