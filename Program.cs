using System;

class Notas
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Sistema de Cálculo de Notas");
        Console.WriteLine("Favor ingrese su Nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor ingrese el nombre de la Asignatura");
        string Asignatura = Console.ReadLine();
        Console.WriteLine("Ingresa la Primera Nota del Parcial");
        int Nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la Segunda Nota del Parcial");
        int Nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la Tercera Nota del Parcial");
        int Nota3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la Cuarta Nota del Parcial");
        int Nota4 = Convert.ToInt32(Console.ReadLine());

        int Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

        if (Promedio < 70)
        {
            Console.WriteLine("Usted está Reprobado");
        }
        else if (Promedio >= 70 && Promedio <= 80)
        {
            Console.WriteLine("Usted se encuentra en la categoría de Bueno");
        }
        else if (Promedio > 80 && Promedio <= 90)
        {
            Console.WriteLine("Usted se encuentra en la categoría de Muy Bueno");
        }
        else if (Promedio > 90 && Promedio <= 100)
        {
            Console.WriteLine("Usted es Sobresaliente");
        }
        else
        {
            Console.WriteLine("Promedio inválido");
        }

        Console.ReadKey();
    }
}