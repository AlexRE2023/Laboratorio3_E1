Console.WriteLine("Se vende: Naranja , Fresa y Mango");
Console.WriteLine("------------------------------------");
Console.WriteLine("Ingrese el tipo de fruta que llevará:");
string fruta = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de cajas:");
int cajas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese los kilometros a recorrer:");
int kilometros = int.Parse(Console.ReadLine());

switch (fruta)
{
    case "naranja":
    case "Naranja":
        if (kilometros < 30)
        {
            int precio = cajas * 2;
            Console.WriteLine("El precio es de " + precio + " soles");
        }
        else if (kilometros >= 30)
        {
            int precio = cajas * 4;
            Console.WriteLine("El precio es de " + precio + " soles");
        }
        break;
    case "fresa":
    case "Fresa":
        if (kilometros < 30)
        {
            int precio = cajas * 6;
            Console.WriteLine("El precio es de " + precio + " soles");
        }
        else if (kilometros >= 30)
        {
            int precio = cajas * 9;
            Console.WriteLine("El precio es de " + precio + " soles");
        }
        break;
    case "mango":
    case "Mango":
        if (kilometros < 30)
        {
            int precio = cajas * 3;
            Console.WriteLine("El precio es de " + precio + " soles");
        }
        else if (kilometros >= 30)
        {
            int precio = cajas * 5;
            Console.WriteLine("El precio es de " + precio + " soles");
            
        }
        break;
}
