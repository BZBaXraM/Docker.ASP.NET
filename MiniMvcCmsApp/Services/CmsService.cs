using Microsoft.EntityFrameworkCore;
using MiniMvcCmsApp.Data;
using MiniMvcCmsApp.Models;

namespace MiniMvcCmsApp.Services;

public class CmsService(CmsContext context) : IAsyncCmsService
{
    private readonly CmsContext _context = context;

    public async Task<OrderViewModel> OrderAsync(OrderViewModel orderViewModel)
    {
        var order = new OrderViewModel
        {
            Id = Guid.NewGuid(),
            Name = orderViewModel.Name,
            Surname = orderViewModel.Surname,
            Phone = orderViewModel.Phone,
            Address = orderViewModel.Address,
            Order = orderViewModel.Order,
            Count = orderViewModel.Count,
            Notes = orderViewModel.Notes,
            IsDelivered = false
        };

        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();

        return order;
    }

    public async Task<List<OrderViewModel>> GetOrdersAsync()
    {
        return await _context.Orders.ToListAsync();
    }

    public async Task<OrderViewModel> GetOrderByIdAsync(Guid id)
    {
        return (await _context.Orders.FirstOrDefaultAsync(x => x.Id == id))!;
    }

    public async Task<OrderViewModel> UpdateOrderAsync(OrderViewModel orderViewModel)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == orderViewModel.Id);
        if (order == null) return null!;
        order.Name = orderViewModel.Name;
        order.Surname = orderViewModel.Surname;
        order.Phone = orderViewModel.Phone;
        order.Address = orderViewModel.Address;
        order.Order = orderViewModel.Order;
        order.Count = orderViewModel.Count;
        order.Notes = orderViewModel.Notes;
        order.IsDelivered = orderViewModel.IsDelivered;

        await _context.SaveChangesAsync();

        return order;
    }

    public async Task DeleteOrderAsync(Guid id)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        if (order == null) return;
        _context.Orders.Remove(order);

        await _context.SaveChangesAsync();
    }
}