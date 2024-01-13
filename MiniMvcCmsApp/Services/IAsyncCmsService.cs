using MiniMvcCmsApp.Models;

namespace MiniMvcCmsApp.Services;

public interface IAsyncCmsService
{
    Task<OrderViewModel> OrderAsync(OrderViewModel orderViewModel);
    Task<List<OrderViewModel>> GetOrdersAsync();
    Task<OrderViewModel> GetOrderByIdAsync(Guid id);
    Task<OrderViewModel> UpdateOrderAsync(OrderViewModel orderViewModel);
    Task DeleteOrderAsync(Guid id);
}