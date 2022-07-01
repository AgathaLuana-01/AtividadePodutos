using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePodutos
{
    public class Estoque
    {
        List<Alimentos> alimentos = new List<Alimentos>();
        List<Limpeza> limpezas = new List<Limpeza>();
        List<Bebidas> bebidas = new List<Bebidas>();
        List<Produto> produtos = new List<Produto>();

        Produto produto = new Produto();

        //Cadastro que qualquer produto tem em comum
        public void cadastro()
        {            
            Console.WriteLine("______>.<_______Cadastro!!______>.<_______");
            Console.Write("Descrição do material: ");
            produto.descricao_material = Console.ReadLine();
            Console.Write("Data de cadastro: ");
            produto.dataCadastro = Console.ReadLine();
            Console.Write("Quantidade: ");
            produto.quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n...........................................\n");
        }

        public void escolhaDeProduto()
        {
            Menus.menuEscolhaProduto();
            int op = 1;
            var str1 = Console.ReadLine();
            op = Convert.ToInt32(str1);
            if (op > 3)
            {
                Console.WriteLine("Ops:... Valor inválido");
            }
            else
            {                
                switch (op)
                {
                    //Alimento
                    case 1:
                        escolhaAlimento();
                        break;
                    //Bebida
                    case 2:
                        escolhaBebida();                        
                        break;
                    //Limpeza
                    case 3:
                        escolhaLimpeza();
                        break;
                    default:
                        Console.WriteLine(".................................\n\n");
                        break;                        
                }

            }
        }
        public void escolhaAlimento()
        {
            int v;
            var converte = "";
            Alimentos alimento = new Alimentos();
            Console.WriteLine("Alimento perecivel?? 1 = sim");
            converte = Console.ReadLine();
            v = Convert.ToInt32(converte);
            if (v == 1)
            {
                alimento.perecivel = "Sim";
            }
            else
            {
                alimento.perecivel = "Não";
            }
            alimento.dataCadastro = produto.dataCadastro;
            alimento.descricao_material = produto.dataCadastro;
            alimento.quantidade = produto.quantidade;
            alimentos.Add(alimento);
            Console.WriteLine(">.< ____________________________________ >.<\n\n");
        }
        
        public void escolhaBebida()
        {
            Bebidas bebida = new Bebidas();
            Console.Write("Quantidade de litros por bebida: ");
            var qtdLitros = Console.ReadLine();
            int qtdLitrosI = Convert.ToInt32(qtdLitros);
            bebida.litros = qtdLitrosI;
            Console.Write("Bebida alcoólica?\n1. Sim:\t");
            var alcoolica = Console.ReadLine();
            int alcoolicaInt = Convert.ToInt32(alcoolica);
            if (alcoolicaInt == 1)
            {
                bebida.alcoolico = "Sim";
            } else
            {
                bebida.alcoolico = "Não";
            } 
            bebida.dataCadastro = produto.dataCadastro;
            bebida.descricao_material = produto.descricao_material;
            bebida.quantidade = produto.quantidade;
            bebidas.Add(bebida);
            Console.WriteLine(">.< ____________________________________ >.<\n\n");
        }

        public void escolhaLimpeza()
        {
            int v;
            var converte = "";
            Limpeza limpeza = new Limpeza();
            Console.WriteLine("Material Biodegradavel?? 1 = sim");
            converte = Console.ReadLine();
            v = Convert.ToInt32(converte);
            if (v == 1)
            {
                limpeza.biodegradavel = "Sim";
                Console.WriteLine("Material Biodegradavel");
            }
            else
            {
                limpeza.biodegradavel = "Não";
            }
            limpeza.dataCadastro = produto.dataCadastro;
            limpeza.descricao_material = produto.descricao_material;
            limpeza.quantidade = produto.quantidade;
            limpezas.Add(limpeza);
            Console.WriteLine(">.< ____________________________________ >.<\n\n");
        }
        public void consultas()
        {

            Console.WriteLine("_____________Consulta________________");
            Console.WriteLine("Lista de Materiais cadastrados");
            Menus.menuEscolhaProduto();
            int op = 1;
            var str1 = Console.ReadLine();
            op = Convert.ToInt32(str1);
            if (op > 3)
            {
                Console.WriteLine("Ops:... Valor inválido");
            } else
            {
                switch (op)
                {
                    //Alimento
                    case 1:
                        if (alimentos.Count > 0)
                        {
                            Console.WriteLine(".........Alimentos cadastrados:.........\n\n");
                            foreach (var a in alimentos)
                            {
                                a.exibirDados();
                                a.exibirDadosEspecificos();
                                //Console.WriteLine("Descrição do material: " + a.descricao_material + "\n" + "Data de cadastro: " + a.dataCadastro + "\n" + "Quantidade: " + a.quantidade + "\n" + "Perecivel: " + a.perecivel);
                                Console.WriteLine("\n.....................................\n");
                            }
                        }
                        break;
                    //Bebida
                    case 2:
                        if(bebidas.Count > 0)
                        {
                            Console.WriteLine(".........Bebidas cadastradas:.........\n\n");
                            foreach (var b in bebidas)
                            {
                                b.exibirDados();
                                b.exibirDadosEspecificos();
                                Console.WriteLine("\n.....................................\n");
                            }
                        }
                        break;
                    //limpeza
                    case 3:
                        if(limpezas.Count > 0)
                        {
                            Console.WriteLine(".........Produtos de limpeza cadastrados:.........\n\n");
                            foreach (var l in limpezas)
                            {
                                l.exibirDados();
                                l.exibirDadosEspecificos();
                                Console.WriteLine("\n.....................................\n");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine(".................................\n\n");
                        break;
                }
            }



        }

        public void solicitacaoItem()
        {
            string idProduto;
            
            produtos.AddRange(alimentos);
            produtos.AddRange(limpezas);
            produtos.AddRange(bebidas);
            if (produtos.Count > 0)
            {
                Console.WriteLine("Informe a descrição do produto: ");
                idProduto = Console.ReadLine();

                foreach(var a in produtos)
                {
                    if (a.descricao_material == idProduto)
                    {
                        a.exibirDados();
                        a.exibirDadosEspecificos();
                    }
                }
            }

        }
    }
}
