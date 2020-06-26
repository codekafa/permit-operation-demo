using Autofac;
using Business;
using Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.IoC
{
    public static class IoCManager
    {
        public static class IoCUtil
        {

            private static IContainer _container = null;
            private static IContainer Container
            {
                get
                {
                    if (_container == null)
                    {
                        _container = BootstrapContainer();
                    }
                    return _container;
                }
                set { _container = value; }
            }
            private static IContainer BootstrapContainer()
            {
                var builder = new ContainerBuilder();

                //register permissions
                builder.RegisterType<AnnualPermission>().Named<IPermission>("Annual");
                builder.RegisterType<ExcusePermission>().Named<IPermission>("Excuse");
                builder.RegisterType<HourlyPermission>().Named<IPermission>("Hourly");

                var container = builder.Build();
                return container;
            }

            public static T ResolveNamed<T>(string resolveName)
            {
                return Container.ResolveNamed<T>(resolveName);
            }
        }
    }
}
