using DurationOfWorkOrder.Core.DataAccess.InMemory;
using DurationOfWorkOrder.DataAccess.Abstract;
using DurationOfWorkOrder.Entities.Concrete;

namespace DurationOfWorkOrder.DataAccess.Concrete.InMemory
{
    public class IMWorkOrderDal : InMemoryEntityRepositoryBase<WorkOrder>, IWorkOrderDal
    {
        
    }
}
