using System;

namespace CocoFechas01
{
    class Program
    {
        static void Main(string[] args)
        {
            var dia1 = new Dia();
            var dia2 = new Dia();
            dia1.setFecha();            
            Console.WriteLine("***************");
            Console.WriteLine("El dia 1 es: " + dia1.getFecha().ToString("dd, MMMM, yyyy"));
            Console.WriteLine("***************");
            dia2.setFecha();
            Console.WriteLine("***************");
            Console.WriteLine("El dia 2 es: " + dia2.getFecha().ToString("dd, MMMM, yyyy"));
            Console.WriteLine("***************");
            switch (DateTime.Compare(dia1.getFecha(), dia2.getFecha())){
                case 1:
                    Console.WriteLine("La diferencia de dias es de: " + ((dia1.getFecha() - dia2.getFecha()).TotalDays));
                    Console.WriteLine("La diferencia de semanas es de: " + (Math.Round((dia1.getFecha() - dia2.getFecha()).TotalDays/7)));
                    break;
                case -1:
                    Console.WriteLine("La diferencia de dias es de: " + ((dia2.getFecha() - dia1.getFecha()).TotalDays));
                    Console.WriteLine("La diferencia de semanas es de: " + (Math.Round((dia2.getFecha() - dia1.getFecha()).TotalDays / 7)));
                    break;
                case 0:
                    Console.WriteLine("Las fechas son iguales");
                    break;
            }           
        }
    }
}
