using System;

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

        private static void ExcluirSerie()
        {
            Console.Write("Escolha o ID da série para excluir: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorID(indiceSerie);
            Console.WriteLine(indiceSerie);
        }


        private static void VisualizarSerie()
        {
            Console.Write("Escolha o ID da série para visualizar: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorID(indiceSerie);
            Console.WriteLine(serie);
        }        





        private static void AtualizarSerie()
        {
            Console.Write("Atualize a série");
            int indiceSerie = int.Parse(Console.ReadLine());

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0} . {1}", i, Enum.GetName(typeof(Genero), i));
                }

            Console.Write("Digite o gênero de acordo com as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie (id: indiceSerie,
                            genero: (Genero) entradaGenero,
                            titulo: entradaTitulo,
                            ano: entradaAno,
                            descricao: entradaDescricao;

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }    


         private static void ListarSerie()
         {
             Console.WriteLine("Listar Series");
             var lista = repositorio.Lista();

             if (lista.Count == 0)
             {
                Console.WriteLine("Nenhuma série cadastrada");
                 return;                 
             }

             foreach (var serie in lista)
             {
                 var excluido = serie.retornaExcluido();
                 Console.WriteLine("#Id {0}: - {1} {2}", serie.retornaId(), serie.retornaTítulo(), (excluido ? "*Excluido*" : ""));
             }

         }



        private static void AdicionarSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero de acordo com as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie (id: repositorio.ProximoId(),
                                                                genero: (Genero) entradaGenero,
                                                                titulo: entradaTitulo,
                                                                ano: entradaAno,
                                                                descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
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
        

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;

        }
        

    }
}




