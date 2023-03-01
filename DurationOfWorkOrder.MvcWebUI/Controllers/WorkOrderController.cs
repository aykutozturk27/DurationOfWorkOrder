using DurationOfWorkOrder.Business.Abstract;
using DurationOfWorkOrder.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DurationOfWorkOrder.MvcWebUI.Controllers
{
    public class WorkOrderController : Controller
    {
        private readonly IWorkOrderService _workOrderService;

        public WorkOrderController(IWorkOrderService workOrderService)
        {
            _workOrderService = workOrderService;
        }

        public IActionResult Index()
        {
            var workOrderList = new WorkOrderModel
            {
                WorkOrders = _workOrderService.GetAll()
            };
            return View(workOrderList);
        }
    }
}
