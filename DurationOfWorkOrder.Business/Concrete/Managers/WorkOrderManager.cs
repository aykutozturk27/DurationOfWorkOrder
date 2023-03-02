using DurationOfWorkOrder.Business.Abstract;
using DurationOfWorkOrder.DataAccess.Abstract;
using DurationOfWorkOrder.Entities.Concrete;

namespace DurationOfWorkOrder.Business.Concrete.Managers
{
    public class WorkOrderManager : IWorkOrderService
    {
        private readonly IWorkOrderDal _workOrderDal;
        private List<WorkOrder> _workOrders;
        public WorkOrderManager(IWorkOrderDal workOrderDal)
        {
            _workOrderDal = workOrderDal;
            _workOrders = new List<WorkOrder>()
            {
                new WorkOrder() { Id = 1, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,10,0,0),DurationEnd = new DateTime(2017,1,1,10,10,0) },
                new WorkOrder() { Id = 2, DurationName = "Arıza", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,10,30,0),DurationEnd = new DateTime(2017,1,1,11,0,0) },
                new WorkOrder() { Id = 3, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,12,0,0),DurationEnd = new DateTime(2017,1,1,12,30,0) },
                new WorkOrder() { Id = 4, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,14,0,0),DurationEnd = new DateTime(2017,1,1,14,10,0) },
                new WorkOrder() { Id = 5, DurationName = "Setup", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,15,0,0),DurationEnd = new DateTime(2017,1,1,16,30,0) },
                new WorkOrder() { Id = 6, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,18,0,0),DurationEnd = new DateTime(2017,1,1,18,10,0) },
                new WorkOrder() { Id = 7, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,20,0,0),DurationEnd = new DateTime(2017,1,1,20,30,0) },
                new WorkOrder() { Id = 8, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,22,0,0),DurationEnd = new DateTime(2017,1,1,22,10,0) },
                new WorkOrder() { Id = 9, DurationName = "Arge", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,1,23,0,0),DurationEnd = new DateTime(2017,1,2,8,30,0) },
                new WorkOrder() { Id = 10, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,2,10,0,0),DurationEnd = new DateTime(2017,1,2,10,10,0) },
                new WorkOrder() { Id = 11, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,2,12,0,0),DurationEnd = new DateTime(2017,1,2,12,30,0) },
                new WorkOrder() { Id = 12, DurationName = "Arıza", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,2,13,0,0),DurationEnd = new DateTime(2017,1,2,13,45,0) },
                new WorkOrder() { Id = 13, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,2,14,0,0),DurationEnd = new DateTime(2017,1,2,14,10,0) },
                new WorkOrder() { Id = 14, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,2,18,0,0),DurationEnd = new DateTime(2017,1,2,18,10,0) },
                new WorkOrder() { Id = 15, DurationName = "Arge", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,2,20,0,0),DurationEnd = new DateTime(2017,1,3,2,10,0) },
                new WorkOrder() { Id = 16, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,3,4,0,0),DurationEnd = new DateTime(2017,1,3,4,30,0) },
                new WorkOrder() { Id = 17, DurationName = "Setup", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,3,6,0,0),DurationEnd = new DateTime(2017,1,3,9,30,0) },
                new WorkOrder() { Id = 18, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,3,10,0,0),DurationEnd = new DateTime(2017,1,3,10,10,0) },
                new WorkOrder() { Id = 19, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,3,12,0,0),DurationEnd = new DateTime(2017,1,3,12,30,0) },
                new WorkOrder() { Id = 20, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,3,14,0,0),DurationEnd = new DateTime(2017,1,3,14,10,0) },
                new WorkOrder() { Id = 21, DurationName = "Arıza", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,3,15,0,0),DurationEnd = new DateTime(2017,1,3,18,45,0) },
                new WorkOrder() { Id = 22, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,3,20,0,0),DurationEnd = new DateTime(2017,1,3,20,30,0) },
                new WorkOrder() { Id = 23, DurationName = "Mola", WorkOrderCode = "1101",
                    DurationStart = new DateTime(2017,1,3,22,0,0),DurationEnd = new DateTime(2017,1,3,22,10,0) }
            };
        }

        public List<WorkOrder> GetAll()
        {
            var workOrderList = _workOrderDal.GetList(_workOrders);
            return workOrderList;
        }

        public async Task<List<WorkOrder>> GetAllAsync()
        {
            var workOrderList = await _workOrderDal.GetListAsync(_workOrders);
            return workOrderList;
        }
    }
}
