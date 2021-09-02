using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DIO_Séries.Interface;

namespace Projeto_DIO_Séries
{
    public class SerieRepositorio : IRepositorio<Serie>
    //ela implementa uma interface, só que implementa uma interface do repositorio de Serie 
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
           listaSerie[id] = objeto;//vai receber o objeto e coloca o objeto na posição no vetor
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int proximoId()
        {
            return listaSerie.Count();
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
