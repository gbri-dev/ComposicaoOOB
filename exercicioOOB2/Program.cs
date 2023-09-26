using exercicioOOB2.Entity;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*
  Console output:
  Post.Title
  Post.Likes - Post.Moment
  Post.Content
  Comments:
  Comment.Text
*/

Comment c1 = new Comment("Have a nice trip!");
Comment c2 = new Comment("How that's awesome!");

Post p1 = new Post(
  DateTime.Parse("21/06/2018 13:05:44"),
  "Traveling to new zealand",
  "Nada a declarar",
  33
  );

p1.AddComment(c1);
p1.AddComment(c2);

Console.WriteLine(p1);


// Console.Write("Criar um post ");
// Console.Write("Momento do post (dd/MM/YYYY)");
// DateTime moment = DateTime.Parse(Console.ReadLine());
// Console.Write("Titulo do post: ");
// string title = Console.ReadLine();
// Console.WriteLine("Conteúdo do post: ");
// string content = Console.ReadLine();
// Console.Write("Likes: ");
// int likes = Convert.ToInt32(Console.ReadLine());



