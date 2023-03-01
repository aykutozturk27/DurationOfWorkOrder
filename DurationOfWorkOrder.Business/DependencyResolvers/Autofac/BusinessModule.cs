using Autofac;
using DurationOfWorkOrder.Business.Abstract;
using DurationOfWorkOrder.Business.Concrete.Managers;
using DurationOfWorkOrder.DataAccess.Abstract;
using DurationOfWorkOrder.DataAccess.Concrete.InMemory;

namespace DurationOfWorkOrder.Business.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<WorkOrderManager>().As<IWorkOrderService>().SingleInstance();
            builder.RegisterType<IMWorkOrderDal>().As<IWorkOrderDal>().SingleInstance(); 
        }
    }
}
