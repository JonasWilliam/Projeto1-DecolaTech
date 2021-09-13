using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Series
{
  public  class Serie : EntidadeBase{
 //

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private Boolean Excluido { get; set; }

    public Serie(int id, Genero genero, String descricao, int ano, String titulo)
        {
            this.id = id;
            this.Genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Titulo = titulo;
            this.Excluido = false;
        }

        public override string ToString()
        {
            String retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Genero + Environment.NewLine;
            retorno += "Descrição: " + this.Genero + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Genero + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}
