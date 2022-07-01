using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePodutos
{
    public class Produto 
    {
        public string descricao_material { get; set; }
        public string dataCadastro { get; set; }
        public int quantidade { get; set; }

        public virtual void exibirDadosEspecificos()
        {

        }

        public void exibirDados()
        {
            Console.WriteLine("Descrição do material: " + descricao_material);
            Console.WriteLine("Data cadastro: " + dataCadastro);
            Console.WriteLine("Quantidade: " + quantidade);
        }

    }
}
