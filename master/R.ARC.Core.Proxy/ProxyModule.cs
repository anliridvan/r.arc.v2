using Autofac;

namespace R.ARC.Core.Proxy
{

    public class ProxyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();
        }
    }
}
