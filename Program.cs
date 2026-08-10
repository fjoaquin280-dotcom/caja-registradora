Console.WriteLine("Hello, World!");
string marketName = "open24";

Console.Write("Ingrese su nombre: ");
string userName = Console.ReadLine();
Console.WriteLine($"Hola, {userName}. Bienvenido a {marketName}.");
Console.ReadLine();

Console.Write("ingrese el nombre del producto:");
string productName = Console.ReadLine();

Console.Write("ingrese el precio del producto:");
string productPrice = Console.ReadLine();
decimal price = decimal.Parse (productPrice);

Console.Write($"El producto es {productName} y el precio del producto es ${price}");
Console.ReadLine();