string dias;
do
{
    Console.Write("Escriba el dia: ");
    dias = Console.ReadLine();
    if (dias == "lunes"|| dias == "martes"|| 
        dias == "miercoles"|| dias == "jueves"|| 
        dias == "viernes") Console.WriteLine("Trabajar y estudiar");
    if (dias == "sabado") Console.WriteLine("Trabajar");
    if (dias == "domingo") Console.WriteLine("dormir");
    Console.WriteLine("");
    if (dias != "lunes" && dias != "martes" &&
        dias != "miercoles" && dias != "jueves" &&
        dias != "viernes" && dias != "sabado" &&
        dias != "domingo")
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("El dia no esta en la lista");
        Console.WriteLine("--------------------------");
        Console.WriteLine("");
    }
} while (dias != null);