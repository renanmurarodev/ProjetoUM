namespace ProjetoUm
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        
    
        // Métodos
 

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            return retorno;

            // Environment.NewLine: interpreta como o SO vai criar uma nova linha, evitando ter que descobrir qual o comando certo para uma nova linha.

        }

        public string retornaTítulo()
        {
            return this.Titulo; 
        }

        public int retornaID()
        {
          return this.Id;
        }
        
    }
}