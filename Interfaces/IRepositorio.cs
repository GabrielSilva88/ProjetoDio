using System.Collections.Generic;

namespace ProjetoDio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaPorId(int id);
         void Inserir(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int proximoId();
    }
}