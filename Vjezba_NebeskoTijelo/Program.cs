using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_NebeskoTijelo
{
    class GeometrijskoTijelo
    {
        protected double Volumen;
        protected double Oplosje;
        public static int BrojacTijela;

        public GeometrijskoTijelo()
        {
            BrojacTijela++;
        }
    }

    class Kugla : GeometrijskoTijelo
    {
        
    }

    class Kvadar : GeometrijskoTijelo
    {

    }

    class Kocka : Kvadar
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
             Kugla x = new Kugla();
             Console.WriteLine(GeometrijskoTijelo.BrojacTijela);
             Kvadar y = new Kvadar();
             Console.WriteLine(GeometrijskoTijelo.BrojacTijela);
             Kocka z = new Kocka();
             Console.WriteLine(GeometrijskoTijelo.BrojacTijela);



            Console.ReadKey();
        }

            
        }
    }

