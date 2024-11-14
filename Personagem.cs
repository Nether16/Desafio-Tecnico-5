using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico_5
{
    class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public Inventario inventario { get; set; }

        public Personagem(string nome, int vida, int mana, Inventario inventario)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            this.inventario = inventario;
        }

        public void MostrarCoisas()
        {
            Console.WriteLine($"Nome : {Nome}  | Vida : {Vida} | Mana : {Mana}");
            int i = 0;
            foreach(var item in inventario.itens)
            {
                i++;
                Console.WriteLine($"{i} - {item}");
            }
            Console.WriteLine();
        }
    }

    class Inventario
    {
        public List<string> itens = new List<string>();
        private Dictionary<int, string> ItensDic = new Dictionary<int, string>
        {
            {0, "Poção de Cura" }, {1, "Poção de Mana" }, {2, "Pena de Fenix" }, {3, "Espada" },
            {4, "Arco" }, {5, "Mosquete" }, {6, "Cajado" }, {7, "Armadura" },{8, "Manto" },
            {9, "Botas" },
        };

        private string IdToItem(int Id)
        {
            foreach (var item in ItensDic)
            {
                if (item.Key == Id)
                {
                    return item.Value;
                }
            }
            return "";
        }
        public Inventario(int[] itens)
        {
            foreach (var item in itens)
            {
                this.itens.Add(IdToItem(item));
            }
        }
    }
}
