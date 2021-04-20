using IdenTranning.Interface.Request;
using IdenTranning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenTranning.Interface
{
    public interface IMusicService
    {
        Task<int> Create(CreateMusicRequest request);
        Task<int> UpdateAsync(UpdateMusicRequest request);
        Task<int> Delete(int IdMusic);

        Task<List<MusicView>> GetAll(string keyword); 
    }
}
