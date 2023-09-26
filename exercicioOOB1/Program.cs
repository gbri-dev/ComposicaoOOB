// See https://aka.ms/new-console-template for more information
using System.Globalization;
using exercicioOOB1.Entity;
using exercicioOOB1.Entity.Enums;

Console.WriteLine("Hello, World!");
for (int i = 0; i <= 10; i++)
{
  Console.Write("*_*_");
}
Console.WriteLine(" ");
/*
  Criar trabalhador por departamento
  Vincular contratos de trabalho a ele
  Excluir contratos de trabalho
  calcular a sua receita do mes
*/

Console.Write("Enter department's name: ");
string depName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base Salary? ");
double baseSalery = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

/*Instanciar os nossos objetos*/

Department dept = new Department(depName);

Worker worker = new Worker(name, level, baseSalery, dept);

Console.WriteLine("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
  Console.WriteLine($"Enter #{i} contract data: ");
  Console.Write("Date (DD/MM/YYYY): ");
  DateTime date = DateTime.Parse(Console.ReadLine());
  Console.Write("Value per hour: ");
  double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
  Console.Write("Duration (hours): ");
  int hours = int.Parse(Console.ReadLine());

  HourContract contract = new HourContract(date, valuePerHour, hours);
  worker.AddContract(contract);
}

Console.Write("Entre com o mês e ano para calcular o ganho MM/YYYY: ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));/*Ex: 08/2023 da posição 3 em diante é 2023*/
Console.WriteLine(" ");
/*Resultado final*/
for (int i = 0; i <= 10; i++)
{
  Console.Write("*_*_");
}
Console.WriteLine(" ");
Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Level: " + worker.Level);
Console.WriteLine("Department: " + worker.Department.Name);
for (int i = 0; i <= 10; i++)
{
  Console.Write("*_*_");
}

Console.WriteLine(" ");
Console.WriteLine("Seu ganho em " + monthAndYear + " foi de R$" + worker.Income(month, year).ToString("F2", CultureInfo.InvariantCulture));
