using System;
using Autofac;
using PDD.DAL;

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
            builder.RegisterGeneric(typeof (EfDal.Repository<>))
                .As(typeof (IRepository<>))
                .InstancePerLifetimeScope();
            Container = builder.Build();
        }
        public static IocContainer Instance => _instance.Value;
    }
}
