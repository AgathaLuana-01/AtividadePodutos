using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePodutos
{
    public class Alimentos : Produto
    {
        public string perecivel { get; set; }


        public override void exibirDadosEspecificos()
        {
            Console.WriteLine("É perecivel: " + perecivel);
        }
    }
}
