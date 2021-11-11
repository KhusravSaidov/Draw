using System;

namespace TestApp.Drawers
{
    public class LazyDrawer : Drawer
    {
        public LazyDrawer(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"{name} too lazy. I don't want to do anything");
        }
    }
}
