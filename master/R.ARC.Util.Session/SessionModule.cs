using Autofac;
using System.Text;

namespace R.ARC.Core.DataAccess
{
    public class SessionModule : Module //Not Used 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();
        }
    }
}
