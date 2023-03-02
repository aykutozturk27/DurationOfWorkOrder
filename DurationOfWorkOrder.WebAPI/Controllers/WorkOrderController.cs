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
            int generalTotalDurations = 0;
            int duration = 0;
            var durations = new List<int>();
            var totalDurations = new List<int>();
            for (int i = 0; i < workOrders.Count; i++)
            {
                duration = (workOrders[i].DurationEnd - workOrders[i].DurationStart).Minutes;
                durations.Add(duration);
                totalDurations.Add(duration + durations[i]);
                generalTotalDurations += totalDurations[i];
            }
            var workOrderModel = new WorkOrderModel
            {
                WorkOrders = workOrders,
                Durations = durations,
                TotalDurations = totalDurations,
                GeneralTotalDuration = generalTotalDurations
            };
            return Ok(workOrderModel);
        }
    }
}
