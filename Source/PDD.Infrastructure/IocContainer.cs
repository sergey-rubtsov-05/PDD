using System;
using Autofac;
using PDD.EfDal;

namespace PDD.Infrastructure
{
    public sealed class IocContainer
    {
        // ReSharper disable once InconsistentNaming
        private static readonly Lazy<IocContainer> _instance = new Lazy<IocContainer>(() => new IocContainer());

        public IContainer Container { get; private set; }

        private IocContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterGeneric(typeof (Repository<>))
                .As(typeof (IGenericRepository<>))
                .InstancePerLifetimeScope();
            Container = builder.Build();
        }
        public static IocContainer Instance => _instance.Value;
    }
}
