using Autofac;

namespace DurationOfWorkOrder.Business.DependencyResolvers.Autofac
{
    public static class InstanceFactory
    {
        private static ContainerBuilder _container;
        private static IContainer container;

        public static T GetInstance<T>()
        {
            _container = new ContainerBuilder();
            container = _container.Build();
            return container.Resolve<T>();
        }
    }
}
