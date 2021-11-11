using System;
using TestApp.Interfaces;

namespace TestApp.Drawers
{
    public class Drawer : IDrawer
    {
        protected string name;

        public Drawer(string name)
        {
            this.name = name;
        }

        public virtual void Draw()
        {
            Console.WriteLine("NO SHAPE");
        }
    }
}

