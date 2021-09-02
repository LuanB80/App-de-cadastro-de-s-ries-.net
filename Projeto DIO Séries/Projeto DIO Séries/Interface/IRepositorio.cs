using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DIO_Séries.Interface
{
    public interface IRepositorio<T>//Ele passa esse T que é generico
        //quem for implementar essa interface, é obrigado a implementar os métodos
    {
        List<T> Lista();// esse metodo retorna uma lista de T
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int proximoId();
    }
}
