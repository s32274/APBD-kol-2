using ExampleTest2.DTOs;

namespace ExampleTest2.Services;

public interface IDbService
{
    Task<OrderDto> GetOrderById(int id);
    Task FulfillOrder(int id, FulfillOrderDto dto);
}