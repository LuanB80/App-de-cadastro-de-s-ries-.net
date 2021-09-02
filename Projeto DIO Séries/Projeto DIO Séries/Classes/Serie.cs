using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DIO_Séries
{
    public class Serie : EntiadadeBase  //Minha classe serie, está herdando na minha classe base
    {
        // isso é os atributos 
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string  Descrição { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Esses são os métodos
        public Serie(int id, Genero genero, string titulo,  string descrição, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrição = descrição;
            this.Ano = ano;
            this.Excluido = false;
        }

        //implementação do ToString, o tostring, é pra quando eu for converter um objeto dos metodos, para string, ele executa a ação
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;//esse enviroment é só para uma nova linha
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descrição + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        //eu uso isso para quando eu for fazer a listagem das séries
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {// aqui é para saber se tá excluido ou não
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}   

