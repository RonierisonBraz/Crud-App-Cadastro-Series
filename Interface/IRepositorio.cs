using System.Collections.Generic;

namespace DIO.Series.Interface
{
    public interface IRepositorio<T>
    {
         List<T> Listar();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Excluir(int id);
         void Atualizar(int id, T entidade);
         int ProximoId();

    }
}