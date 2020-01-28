using System;
using System.Collections.Generic;
using System.Text;

namespace CocoFechas01
{
    class Dia
    {
        private DateTime fecha;
        
        public void setFecha()            
        {
            //this.fecha.AddYears(ano);
            // this.fecha.AddMonths(mes);
            //this.fecha.AddDays(dia);
            this.fecha = Dia.cargaFecha();
        }
        public DateTime getFecha()
        {
            return this.fecha;
        }
        static public DateTime cargaFecha()
        {
            int dia = 0, mes = 0, ano = 0;
            //var salida = new Dia();

            do
            {
                Console.WriteLine("Ingrese el año: ");
                try
                {
                    ano = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { }
            } while ((ano < 1) || (ano > 2020));            
            do
            {
                Console.WriteLine("Ingrese el mes: ");
                try
                {
                    mes = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { }
            } while ((mes < 1) || (mes > 12));
            if ((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12))
            {
                do
                {
                    Console.WriteLine("Ingrese el dia: ");
                    try
                    {
                        dia = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException) { }
                } while ((dia < 1) || (dia > 31));
            }
            else
            {
                if ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
                {
                    do
                    {
                        Console.WriteLine("Ingrese el dia: ");
                        try
                        {
                            dia = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException) { }
                    } while ((dia < 1) || (dia > 30));
                }
                else
                {
                    if (mes == 2)
                    {
                        do
                        {
                            Console.WriteLine("Ingrese el dia: ");
                            try
                            {
                                dia = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException) { }
                        } while ((dia < 1) || (dia > 28));
                    }
                }
            }            
            var salida = new DateTime(ano, mes, dia);            
            return salida;
        }
    }
}
