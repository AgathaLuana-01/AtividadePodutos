using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePodutos
{
    public class Bebidas : Produto
    {
        public int litros { get; set; }
        public string alcoolico { get; set; }

        public override void exibirDadosEspecificos()
        {
            Console.WriteLine("Litros: " + litros);
            Console.WriteLine("Acoolico: " + alcoolico);
        }
    }
}
