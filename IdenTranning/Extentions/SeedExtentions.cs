using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IdenTranning.Models;

namespace IdenTranning.Extentions
{
    public static class SeedExtentions 
    {
        public static void Seed(this ModelBuilder modelBulder)
        {
            modelBulder.Entity<Music>().HasData(
                  new Music
                  {
                      Id = 1,
                      Name = "Lạc trôi",
                      Single = "Sơn tùng Mtp",
                      CategoriesId = 0,
                      Year = 2017
                  },
                  new Music
                  {
                      Id = 2,
                      Name = "Em của ngày hôm qua",
                      Single = "Sơn tùng Mtp",
                      CategoriesId = 1,
                      Year = 2018
                  },
                  new Music
                  {
                      Id = 3,
                      Name = "Thu cuối",
                      Single = "Yanbi",
                      CategoriesId = 2,
                      Year = 2017
                  }
                  );
            modelBulder.Entity<Categories>().HasData(
                new Categories
                {
                    Id = 1,
                    CateName = "Rap"
                },
                new Categories
                {
                    Id = 2,
                    CateName = "Pop"
                },
                new Categories
                {
                    Id = 3,
                    CateName = "Bolero"
                },
                new Categories
                {
                    Id = 5,
                    CateName = "A&B"
                }
                , new Categories
                {
                    Id = 6,
                    CateName = "Rock"
                }
                    );
            }
        }
    }

