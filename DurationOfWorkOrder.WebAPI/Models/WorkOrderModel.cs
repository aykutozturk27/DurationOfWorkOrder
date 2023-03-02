using DurationOfWorkOrder.Entities.Concrete;

namespace DurationOfWorkOrder.WebAPI.Models
{
    public class WorkOrderModel
    {
        public List<WorkOrder> WorkOrders { get; set; }
        public List<int>? Durations { get; set; } = new List<int>();
        public List<int>? TotalDurations { get; set; } = new List<int> { };
        public int? GeneralTotalDuration { get; set; }
    }
}
