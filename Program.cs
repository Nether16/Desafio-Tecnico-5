using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] itensRamza = { 0, 0, 1, 2, 3, 7, 9 };
            Personagem Ramza = new Personagem("Ramza", 120, 80,new Inventario(itensRamza));

            Ramza.MostrarCoisas();

            int[] itensDelita = { 0, 0, 1, 1, 2, 6, 8, 9 };
            Personagem Delita = new Personagem("Delita", 100, 150, new Inventario(itensDelita));

            Delita.MostrarCoisas();

            Console.ReadLine();
        }
    }
}
