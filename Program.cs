Console.WriteLine("Hello, World!");
//etapa 1 bienvenida y datos del cajero

string marketName = "open24";

Console.Write("Ingrese su nombre: ");
string userName = Console.ReadLine();
Console.WriteLine($"Hola, {userName}. Bienvenido a {marketName}.");
Console.ReadLine();

//etapa 2  carga de un producto

Console.Write("ingrese el nombre del producto:");
string productName = Console.ReadLine();

Console.Write("ingrese el precio del producto:");
string productPrice = Console.ReadLine();
decimal price = decimal.Parse (productPrice);

Console.Write($"El producto es {productName} y el precio del producto es ${price}");
Console.ReadLine();

//etapa 3 carga multiple con menu
string option;
decimal countTotal = price;
int productTotal = 1;
do
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - cargar un producto");
    Console.WriteLine("2 - cerrar ventana");
    Console.WriteLine("escoja una opcion:");
    option = Console.ReadLine();
  
    switch (option)
    {
        case "1":

            Console.Write("ingrese el nombre del producto:");
            productName = Console.ReadLine();
            Console.Write("ingrese el precio del producto:");
            productPrice = Console.ReadLine();
            price = decimal.Parse(productPrice);
            countTotal = countTotal + price;
            productTotal = productTotal + 1;
            break;

        case "2":
            Console.WriteLine($"el total de productos es {productTotal}y el total del percio es ${countTotal}");
            Console.ReadLine();
                break;
        default:
            Console.WriteLine("oopcion invalida, elige una opcion valida");
            Console.ReadLine();
            break;

    }
}
while (option != "2");
