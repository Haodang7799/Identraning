using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdenTranning.Data;
using Microsoft.AspNetCore.Mvc;
using IdenTranning.Models;
using Microsoft.EntityFrameworkCore;
using IdenTranning.Interface;

namespace IdenTranning.Controllers
{

    public class HomeController : Controller
    {
        private readonly IdenDBContext _context;
        private readonly IMusicService _musicService;
        public HomeController(IdenDBContext context, IMusicService musicService)
        {
            _context = context;
            _musicService = musicService;
        }
        public IActionResult Index()
        {
            return View();
        }
     
        public async Task<IActionResult> Tables(string seachString)
        {

             var music = from m in _context.musics
                        select m;
             var category = from a in _context.Categories
                            join b in _context.musics on a.Id equals b.CategoriesId
                            select new MusicView
                            {
                                
                                Name = b.Name,
                                Categories = a.CateName,
                                Single = b.Single,
                                Year = b.Year
                            };
            List<MusicView> list = await _musicService.GetAll(seachString);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
      


    }
}