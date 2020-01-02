using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace R.ARC.Web.Api.Settings.Autofac
{
    public static class AutofacExtensions
    {
        public static IContainer CreateAutofacContainer(this IServiceCollection services,
            Action<ContainerBuilder, IServiceCollection> additionalAction, params Module[] modules)
        {
            var builder = new ContainerBuilder();

            foreach (var module in modules) builder.RegisterModule(module);

            additionalAction?.Invoke(builder, services);

            builder.Populate(services);

            return builder.Build();
        }
    }
}
