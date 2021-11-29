namespace ProjetoUm
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    ListarSerie();
                    break;

                    case "2":
                    AdicionarSerie();
                    break;

                    case "3":
                    AtualizarSerie();
                    break;

                    case "4":
                    ExcluirSerie();
                    break;

                    case "5":
                    VisualizarSerie();
                    break;

                    case "C":
                    Console.Clear();
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                    
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar este serviço");
            Console.ReadLine();

           

        }

         private static void ListarSerie()
         {
             Console.WriteLine("Listar Series");
             var lista = repositorio.Lista();

             if (lista.Count != 0)
             {
                Console.WriteLine("nenhuma série cadastrada");
                return;
             }
         

         foreach (var serie in lista)
         {
             Console.WriteLine("#Id {0}: . {1}", serie.retornaId() , serie.retornaTítulo());
         }

         }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Mercado das Séries. Bem-vindo!");
            Console.WriteLine("Escolha a opção desejada:");


            Console.WriteLine("1 - Listar Série");
            Console.WriteLine("2 - Adicionar Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
        }

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opçãoUsuario;
        )

    }
}




