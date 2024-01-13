using Microsoft.AspNetCore.Mvc;
using MiniMvcCmsApp.Models;
using MiniMvcCmsApp.Services;

namespace MiniMvcCmsApp.Controllers;

public class OrderController(IAsyncCmsService service) : Controller
{
    public async Task<IActionResult> Index()
    {
        var orders = await service.GetOrdersAsync();
        return View(orders);
    }


    [HttpPost]
    public async Task<IActionResult> CreateOrder(OrderViewModel orderViewModel)
    {
        var order = await service.OrderAsync(orderViewModel);
        return View(order);
    }

    [HttpGet]
    public async Task<IActionResult> CreateOrder()
    {
        return await Task.FromResult<IActionResult>(View());
    }

    [HttpGet]
    public async Task<IActionResult> DeleteOrder(Guid id)
    {
        await service.DeleteOrderAsync(id);
        return RedirectToAction("Index");
    }
}