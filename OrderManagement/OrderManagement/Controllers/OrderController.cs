using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Service;
using OrderManagement.Model;

namespace OrderManagement.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController()
        {
            _orderService = new OrderServices();
        }

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult OrderList()
        {
            var orderList = _orderService.GetAllOrders();
            return Json(orderList, JsonRequestBehavior.AllowGet);
        }
    }
}
