using DurationOfWorkOrder.Entities.Concrete;

namespace DurationOfWorkOrder.Business.Abstract
{
    public interface IWorkOrderService
    {
        List<WorkOrder> GetAll();
    }
}
