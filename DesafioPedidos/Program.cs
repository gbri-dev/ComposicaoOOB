/*
  Enter client data
  Name: 
  Email:
  Birth date (DD/MM/YYYY)

  Enter order data
  Status:
  How many items to this order? 

  Enter #1 item data
  Product name:
  Product price: 
  Quantity

  Order Summary
  Order moment:
  Order Status:
  Client:
  Order items:
  Exemple: Tv, R$1000.00, quantity: 1, SubTotal: R$1000.00
  Exemple: Mouse, R$40.00, quantity: 2, SubTotal: R$80.00
  Total price: R$1080.00

*/

using System.Globalization;
using DesafioPedidos.Entities;
using DesafioPedidos.Entities.Enum;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(clientName, email, birthDate);
Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
  Console.WriteLine($"Enter #{i} item data:");
  Console.Write("Product name: ");
  string productName = Console.ReadLine();
  Console.Write("Product price: ");
  double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  Product product = new Product(productName, price);

  Console.Write("Quantity: ");
  int quantity = int.Parse(Console.ReadLine());

  OrderItem orderItem = new OrderItem(quantity, price, product);

  order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);