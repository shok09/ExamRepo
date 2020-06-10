using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public static class StorageContextSeeder
    {
        public static void Seed(StorageContext context)
        {
            var roomsList = new List<Room>
            {
                new Room { TotalVolume = 10000, Toxicity = Entities.Enums.ToxicityLevel.Innocuous},
                new Room { TotalVolume = 5000, Toxicity = Entities.Enums.ToxicityLevel.Harmful },
                new Room { TotalVolume = 2000, Toxicity = Entities.Enums.ToxicityLevel.Destructive }
            };
            var goodsList = new List<Goods>
            {
                new Goods
                {
                    Title = "Gala",
                    Description = "Plate washing tool",
                    Volume = 100,
                    Toxicity = Entities.Enums.ToxicityLevel.Innocuous,
                    ValidityDate = new DateInfo { DateOfMan = new DateTime(2020, 04, 03), DateOfExpire = new DateTime(2024, 10, 03) }
                },
                new Goods
                {
                    Title = "Cif",
                    Description = "Toilet washing tool",
                    Volume = 60,
                    Toxicity = Entities.Enums.ToxicityLevel.Harmful,
                    ValidityDate = new DateInfo { DateOfMan = new DateTime(2020, 03, 02), DateOfExpire = new DateTime(2023, 09, 02) }
                },
                new Goods
                {
                    Title = "Destructor",
                    Description = "Microbe and dirt destruction tool",
                    Volume = 30,
                    Toxicity = Entities.Enums.ToxicityLevel.Destructive,
                    ValidityDate = new DateInfo { DateOfMan = new DateTime(2014, 02, 23), DateOfExpire = new DateTime(2034, 02, 23) }
                }
            };
            foreach (var goods in goodsList)
                context.AllGoods.Add(goods);
            foreach (var room in roomsList)
                context.Rooms.Add(room);

            context.SaveChanges();
        }
    }
}
