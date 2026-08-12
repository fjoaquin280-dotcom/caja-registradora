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
            Console.WriteLine($"el total de los productos es {productTotal} y el total del percio es ${countTotal}");
            Console.ReadLine();
                break;
        default:
            Console.WriteLine("oopcion invalida, elige una opcion valida");
            Console.ReadLine();
            break;

    }
}
while (option != "2");

// etapa 4: descuento por monto
 decimal subTotal = countTotal;
decimal discont = 0;

const decimal discont10 = 0.10m;
const decimal discont5 = 0.05m;

if (subTotal > 50000)
{
    discont = subTotal * discont10;
}
else if (subTotal > 20000)
{
    discont = subTotal * discont5;
}
else
{
    Console.WriteLine("no hay descuento");
}
decimal finalTotal = subTotal - discont;
Console.WriteLine($"el total es ${subTotal}");
Console.WriteLine($"el descuento es ${discont}");
Console.WriteLine($"el total final es ${finalTotal}");
Console.ReadLine();

// etapa 5:
string optionPayment;
do
{
    Console.WriteLine(" Medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito");
    Console.Write("escoja una opcion:");
    optionPayment = Console.ReadLine();

    switch (optionPayment)
    {
        case "1":
            finalTotal = finalTotal - finalTotal * discont10;
            break;
        case "2":
            break;
        case "3":
            finalTotal = finalTotal * 1.15m;
            break;
        default:
            Console.WriteLine("opcion invalida, elige una opcion valida");
            Console.ReadLine();
            break;
    }
}
while (optionPayment != "1" && optionPayment != "2" && optionPayment != "3");

Console.WriteLine($"Total a pagar: ${finalTotal}");
Console.ReadLine();
