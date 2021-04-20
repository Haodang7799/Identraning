using IdenTranning.Interface.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenTranning.Interface
{
    public interface IReponsitory<T>
    {
        Task<int> Create(T request);
        Task<int> UpdateAsync(T request);
        Task<int> Delete(int IdMusic);

        Task<List<T>> GetAll(string keyword);
    }
}
