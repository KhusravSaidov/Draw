using System;
using System.Collections.Generic;
using TestApp.Drawers;

namespace TestApp.Repository
{
    public class DrawerRepository
    {
        private static DrawerRepository instance;

        private List<Drawer> drawers;

        private DrawerRepository(int count)
        {
            drawers = GetDrawersByCount(count);
        }

        private DrawerRepository()
        {
            drawers = GetSeedDrawers();
        }

        public static DrawerRepository GetInstance()
        {
            if (instance == null)
                instance = new DrawerRepository();
            return instance;
        }

        public static DrawerRepository GetInstance(int count)
        {
            if (instance == null)
                instance = new DrawerRepository(count);
            return instance;
        }

        public List<Drawer> GetDrawers() => drawers;

        private List<Drawer> GetSeedDrawers() =>
            new List<Drawer>
            {
                new CircleDrawer(name: "Harry"),
                new RectangleDrawer(name: "Oleg") ,
                new LazyDrawer(name: "Batman")
            };

        private List<Drawer> GetDrawersByCount(int count) // Костыльно, просто хотелось для разнообразия
        {
            var rnd = new Random();
            var seedNames = new string[] { "James", "Robin", "Natasha", "Dima", "Oleg", "Batman" };
            var namesLenght = seedNames.Length;


            var res = new List<Drawer>();
            for (int i = 0; i < count; i++)
            {
                var index = rnd.Next(0, 3);
                res.Add(GenerateByRnd(index));
            }
            return res;

            Drawer GenerateByRnd(int rndDrawerIndex) => rndDrawerIndex switch
            {
                3 => new RectangleDrawer(seedNames[rnd.Next(0, namesLenght)]),
                2 => new CircleDrawer(seedNames[rnd.Next(0, namesLenght)]),
                1 => new LazyDrawer(seedNames[rnd.Next(0, namesLenght)]),
                _ => new CircleDrawer(seedNames[rnd.Next(0, namesLenght)])
            };
        }
    }
}
