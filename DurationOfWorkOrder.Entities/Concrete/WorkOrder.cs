using DurationOfWorkOrder.Core.Entities;

namespace DurationOfWorkOrder.Entities.Concrete
{
    public class WorkOrder : IEntity
    {
        public int Id { get; set; }
        public string? WorkOrderCode { get; set; }
        public string? DurationName { get; set; }
        public DateTime DurationStart { get; set; }
        public DateTime DurationEnd { get; set; }
    }
}
