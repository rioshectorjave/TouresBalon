using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Extensions;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Areas.Orders.ViewModels;
using SimplCommerce.Module.Orders.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using SimplCommerce.Module.ShoppingCart.Services;

namespace SimplCommerce.Module.Orders.Areas.Orders.Controllers
{
    [Area("Orders")]
    [Route("checkout")]
    [Authorize]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IRepositoryWithTypedId<Country, string> _countryRepository;
        private readonly IRepository<StateOrProvince> _stateOrProvinceRepository;
        private readonly IRepository<UserAddress> _userAddressRepository;
        private readonly ICartService _cartService;
        private readonly IWorkContext _workContext;
        private readonly IRepository<Cart> _cartRepository;

        public CheckoutController(
            IRepository<StateOrProvince> stateOrProvinceRepository,
            IRepositoryWithTypedId<Country, string> countryRepository,
            IRepository<UserAddress> userAddressRepository,
            IOrderService orderService,
            ICartService cartService,
            IWorkContext workContext,
            IRepository<Cart> cartRepository)
        {
            _stateOrProvinceRepository = stateOrProvinceRepository;
            _countryRepository = countryRepository;
            _userAddressRepository = userAddressRepository;
            _orderService = orderService;
            _cartService = cartService;
            _workContext = workContext;
            _cartRepository = cartRepository;
        }
        
        [HttpGet("success")]
        public IActionResult Success(long orderId)
        {
            return View(orderId);
        }

        [HttpGet("error")]
        public IActionResult Error(long orderId)
        {
            return View(orderId);
        }

        [HttpPost("cancel")]
        public async Task<IActionResult> Cancel()
        {
            var currentUser = await _workContext.GetCurrentUser();
            var cart = await _cartService.GetActiveCart(currentUser.Id);
            if(cart != null && cart.LockedOnCheckout)
            {
                cart.LockedOnCheckout = false;
                await _cartRepository.SaveChangesAsync();
            }

            return Redirect("~/");
        }

    }
}
