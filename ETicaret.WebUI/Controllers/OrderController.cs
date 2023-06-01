using ETicaret.BusinessLayer.Abstract;
using ETicaret.WebUI.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.WebUI.Controllers
{
    public class OrderController : Controller
    {
      
        private IOrderService _orderService;
        private UserManager<User> _userManager;

        public OrderController(UserManager<User> userManager, IOrderService orderService)
        {
            _userManager = userManager;
            _orderService = orderService;
        }

        public IActionResult GetOrders()
        {
            var userId = _userManager.GetUserId(User);
            var orders = _orderService.GetOrders(userId);
            return View(orders);
        }
    }
}
