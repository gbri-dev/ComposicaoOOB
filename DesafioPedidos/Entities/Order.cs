using System.Globalization;
using System.Text;
using DesafioPedidos.Entities.Enum;

namespace DesafioPedidos.Entities
{
  class Order
  {
    public DateTime Date { get; set; }
    public OrderStatus Status { get; set; }

    public Client Client { get; set; }

    public List<OrderItem> OrderItems { get; set; }
    public Order()
    {
    }

    public Order(DateTime date, OrderStatus status, Client client)
    {
      Date = date;
      Status = status;
      Client = client;
    }

    public void AddItem(OrderItem item)
    {
      OrderItems.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
      OrderItems.Remove(item);
    }

    public double Total()
    {
      double totalPedido = 0.0;
      foreach (OrderItem item in OrderItems)
      {
        totalPedido += item.SubTotal();
      }
      return totalPedido;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
      sb.AppendLine("Order status: " + Status);
      sb.AppendLine("Client: " + Client);
      sb.AppendLine("Order items:");
      foreach (OrderItem item in OrderItems)
      {
        sb.AppendLine(item.ToString());
      }
      sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

      return sb.ToString();
    }

  }
}