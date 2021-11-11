using System;

namespace TestApp.Drawers
{
    public class CircleDrawer : Drawer
    {
        public CircleDrawer(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"{name} drew a Circle");
        }
    }
}
