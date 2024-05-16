using System;

    namespace MayorYMenor
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\nIngrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

           
            int mayor = num1;
            if (num2 > mayor)
            {
                mayor = num2;
            }
            if (num3 > mayor)
            {
                mayor = num3;
            }

            
            int menor = num1;
            if (num2 < menor)
            {
                menor = num2;
            }
            if (num3 < menor)
            {
                menor = num3;
            }


            Console.WriteLine("\nEl número mayor es: " + mayor);
            Console.WriteLine("\nEl número menor es: " + menor);

            Console.ReadLine(); 

        }

    }


}

