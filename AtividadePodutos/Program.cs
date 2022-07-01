using System;

namespace AtividadePodutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opMenu = 0;
            //Instaciando objeto estoque da Class Estoque
            Estoque estoque = new Estoque();
            
            while (opMenu != 4)
            {
                Menus.menu();
                
                int n;
                var str = Console.ReadLine();
                bool result = Int32.TryParse(str, out n);
                opMenu = Convert.ToInt32(str);

                if (!result || opMenu > 3)
                {
                    Console.WriteLine("Erro!!\n");
                }
                else
                {                    

                    switch (opMenu)
                    {
                        //Menu Opções básicas
                        case 1:
                            estoque.cadastro();
                            estoque.escolhaDeProduto();
                            break;
                        case 2:
                            estoque.consultas();
                            break;
                        case 3:
                            estoque.solicitacaoItem();
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;

                    }



                }
            }
            
            

            
            
            /*// Classe de Estoque: 
             * 3 listas de produtos especificos
             * Métodos que correpondem as "atividades"
             * 
             * Classe Produto:
             * Atributos básicos dos produtos, descrição(dados do produto), (dateTime)data e quantidade;
             * 
             * Três class especificas

            */


            //Instanciar Alimentos
            /*Estoque objetoAlimentos = new Alimentos();
            objetoAlimentos.cadastro("Chocolate", "com cereja", 15);*/
        }

       

    }    
}
