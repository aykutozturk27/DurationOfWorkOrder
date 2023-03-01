using DurationOfWorkOrder.Core.DataAccess;
using DurationOfWorkOrder.Entities.Concrete;

namespace DurationOfWorkOrder.DataAccess.Abstract
{
    public interface IWorkOrderDal : IEntityRepository<WorkOrder>
    {
    }
}
