using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    { //classe Serie herda EntidadeBase
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

        // Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{ //o Id não está nessa classe, mas na EntidadeBase
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString() //sobrescreve o ToString() original
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            //dependendo do SO, o ambiente vai pegar como que o SO interpreta uma nova linha (/n, /r, etc)
			string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{ //para não ficar alterando lá em cima que está no private
			return this.Titulo;
		}

		public int retornaId()
		{ 
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}