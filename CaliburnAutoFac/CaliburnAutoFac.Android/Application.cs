using System;
using System.Collections.Generic;
using System.Reflection;
using Android.App;
using Android.Runtime;
using Autofac;
using Caliburn.Micro;

namespace CaliburnAutoFac.Droid
{
    [Application]
    public class Application : CaliburnApplication
    {
        private IContainer _container;

        public Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            Initialize();
        }

        protected override void Configure()
        {
            base.Configure();

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<CaliburnAutoFac.Module>();

            _container = builder.Build();
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return new[] { GetType().Assembly, typeof(CaliburnAutoFac.Module).Assembly };
        }

        protected override void BuildUp(object instance)
        {
            _container.InjectProperties(instance);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            var enumerableOfServiceType = typeof(IEnumerable<>).MakeGenericType(service);
            return (IEnumerable<object>)_container.Resolve(enumerableOfServiceType);
        }

        protected override object GetInstance(Type service, string key)
        {
            return key == null ? _container.Resolve(service) : _container.ResolveKeyed(key, service);
        }
    }
}