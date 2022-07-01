using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePodutos
{
    public class Limpeza : Produto
    {
        public string biodegradavel { get; set; }
        public override void exibirDadosEspecificos()
        {
            Console.WriteLine("Biodegradável: " + biodegradavel);
        }
    }
}
