using System;

namespace Operadores_Y_Strings_de_C_
{
    class Program
    {
        static void Main(string[] args)
        {

Console.WriteLine("=================");
Console.WriteLine("Elige un operador\n" + 
"\n1.- suma"+
"\n2,- resta"+
"\n3.- Multiplicacion"+
"\n4.- division" +
"\n5.- modulo");
Console.WriteLine("=================");

int i1 = 0;

i1 = Convert.ToInt16( Console.ReadLine());

switch(i1){
    case 1:
    Console.WriteLine("Suma");
    Console.WriteLine("Coloca primer numero: ");
            //lo utilizare por si desea colocar desimales 
            double No1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Colocar segundo numero:");
            double No2 = Convert.ToDouble(Console.ReadLine()); 

            double Suma = No1+No2;
            Console.WriteLine("resultado es " + Suma);

            Console.ReadKey();
    break;
    case 2:
    Console.WriteLine("Resta");
    Console.WriteLine("Coloca primer numero: ");
     //lo utilizare por si desea colocar desimales 
            double Nr1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Colocar segundo numero:");
            double Nr2 = Convert.ToDouble(Console.ReadLine()); 

            double resta = Nr1-Nr2;
            Console.WriteLine("resultado es " + resta);

            Console.ReadKey();
    break;
    case 3:
    Console.WriteLine("Multiplicacion");
    Console.WriteLine("Coloca primer numero: ");
     //lo utilizare por si desea colocar desimales 
            double Nm1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Colocar segundo numero:");
            double Nm2 = Convert.ToDouble(Console.ReadLine()); 

            double Multiplicacion = Nm1*Nm2;
            Console.WriteLine("resultado es " + Multiplicacion);

            Console.ReadKey();
    break;
    case 4:
    Console.WriteLine("Division");
    Console.WriteLine("Coloca primer numero: ");
     //lo utilizare por si desea colocar desimales 
            double Nd1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Colocar segundo numero:");
            double Nd2 = Convert.ToDouble(Console.ReadLine()); 

            double division = Nd1/Nd2;
            Console.WriteLine("resultado es " + division);

            Console.ReadKey();
    break;
    case 5:
    Console.WriteLine("Modulo");
    Console.WriteLine("Coloca primer numero: ");
     //lo utilizare por si desea colocar desimales 
            double Nmm1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Colocar segundo numero:");
            double Nmm2 = Convert.ToDouble(Console.ReadLine()); 

            double modulo = Nmm1 % Nmm2;
            Console.WriteLine("resultado es " + modulo);

            Console.ReadKey();
    break;
}

        }
        
    }
}
