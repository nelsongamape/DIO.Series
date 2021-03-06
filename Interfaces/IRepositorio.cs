using System.Collections.Generic;

namespace DIO.series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T retornaporId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}