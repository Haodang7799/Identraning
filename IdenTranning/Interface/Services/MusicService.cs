using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdenTranning.Data;
using IdenTranning.Interface;
using IdenTranning.Interface.Request;
using IdenTranning.Models;
using Microsoft.EntityFrameworkCore;

namespace IdenTranning.Interface.Services
{


    public class MusicService : IMusicService
    {
        private readonly IdenDBContext _context;

        public MusicService(IdenDBContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CreateMusicRequest request)
        {
            var _music = new Music()
            {
                Name = request.Name,
                Single = request.Single,
                CategoriesId = request.CateId,
                Year = request.Year  
            };
            _context.musics.Add(_music);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int IdMusic)
        {
            
            var _music = await _context.musics.FindAsync(IdMusic);        
            _context.musics.Remove(_music);
            return await _context.SaveChangesAsync();

        }

        public async Task<List<MusicView>> GetAll(string keyword)
        {
            var _music = from m in _context.musics
                         select m;
            if(!string.IsNullOrEmpty(keyword)) {
                _music = _music.Where(x => x.Name.Contains(keyword));
            }
            
            var category = from a in _music
                           join b in _context.Categories on a.CategoriesId equals b.Id
                           select new MusicView
                           {      
                               Name = a.Name,
                               Categories = b.CateName,
                               Single = a.Single,
                               Year = a.Year
                           };
            var temp1 = new MusicViewModel
            {
                
                Musics = await category.ToListAsync()
            };

            return await category.ToListAsync();
          

        }

        public async Task<int> UpdateAsync(UpdateMusicRequest request)
        {
            var _music = new Music()
            {
                Name = request.Name,
                Single = request.Single,
                CategoriesId = request.CateId,
                Year = request.Year
            };
            _context.musics.Update(_music);
            return await _context.SaveChangesAsync();
        }
    }


}
