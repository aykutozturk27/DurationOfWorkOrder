using DurationOfWorkOrder.Business.Abstract;
using DurationOfWorkOrder.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DurationOfWorkOrder.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrderController : ControllerBase
    {
        private readonly IWorkOrderService _workOrderService;

        public WorkOrderController(IWorkOrderService workOrderService)
        {
            _workOrderService = workOrderService;
        }

        [HttpGet("GetWorkOrderWithDurations")]
        public IActionResult GetWorkOrderWithDurations()
        {
            var workOrders = _workOrderService.GetAll();
            foreach (var workOrder in workOrders)
            {
                var duration = (workOrder.DurationEnd - workOrder.DurationStart).Minutes;
                workOrder.Durations?.Add(duration);
                workOrder.TotalDurations?.Add(duration + workOrder.Durations[0]);
            }
            var workOrderList = new WorkOrderModel
            {
                WorkOrders = workOrders
            };
            return Ok(workOrderList);
        }
    }
}
