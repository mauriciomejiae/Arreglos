/* Nombre del Autor: Mauricio Mejia Estevez
 Fecha de creación:: 23 de Octubre de 2017
 Ultima modificación: 02 de Noviembre de 2017
 Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi 
trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Salario
    {
        static void Main(string[] args)
        {
            Salario miSalario = new Salario();    //Declaración y creación del objeto
            miSalario.Inicializador();             //Llamada al método Inicializador
            miSalario.Calculos();                  //Llamada al método Calculos
            miSalario.Imprimir();                  //Llamada al método Imprimir
        }

        //Declaración de las variables
        int anteriorSalario;
        int aumentoSalario;
        int nuevoSalario;


        public void Inicializador()
        {
            Console.WriteLine("***     Calcular nuevos sueldos de una empresa hotelera   ***\n");
            //Solicitar por teclado el anterior salario
            Console.Write("Ingrese el anterior salario:");
            anteriorSalario = int.Parse(Console.ReadLine());
        }

        private void Calculos()
        {
            //Inicializando el arreglo porcentaje
            int[] porcentaje = new int[3];
            porcentaje[0] = 10;
            porcentaje[1] = 7;
            porcentaje[2] = 5;
            //Inicializando el arreglo rango salario
            int[] rango = new int[3];
            rango[0] = 700000;
            rango[1] = 1000000;
            rango[2] = 1500000;

            //Condicional aninado para hallar los resultados
            if (anteriorSalario <= rango[2])
            {
                if (anteriorSalario <= rango[0])
                {
                    aumentoSalario = anteriorSalario * porcentaje[0] / 100;
                    nuevoSalario = anteriorSalario + aumentoSalario;
                }


                if (anteriorSalario <= rango[1] && anteriorSalario > rango[0])
                {
                    aumentoSalario = anteriorSalario * porcentaje[1] / 100;
                    nuevoSalario = aumentoSalario + anteriorSalario;
                }


                if (anteriorSalario <= rango[2] && anteriorSalario > rango[1])
                {
                    aumentoSalario = anteriorSalario * porcentaje[2] / 100;
                    nuevoSalario = aumentoSalario + anteriorSalario;
                }
            }
            else
            {
                aumentoSalario = 0;
                nuevoSalario = anteriorSalario;
            }

        }

        public void Imprimir()
        {
            Console.WriteLine("\n***   Resultado  ***");
            Console.WriteLine("\nSu aumento es $" + aumentoSalario + ", Su nuevo salario es $" + nuevoSalario);
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
