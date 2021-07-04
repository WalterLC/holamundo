using System;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=20;
            int numero2=15;
            int suma=0;
            //string nombre=" ";
           // Console.WriteLine("Escriba su nombre"); // mando por pantalla
            //nombre = Console.ReadLine();  // capturo de la pantalla
            
            //Console.WriteLine("Escriba su edad");
            //string num = Console.ReadLine();// me sirve para capturar numeros teclado
            //numero = int.Parse(num);  // convierte de string a entero
            //Console.WriteLine("Su nombre es: "+nombre);
            //Console.WriteLine(numero);
            suma= Suma(numero,numero2);
            Console.WriteLine(suma);

        }

        static int Suma(int n, int n2){
            return n+n2;

        }


    }
}
