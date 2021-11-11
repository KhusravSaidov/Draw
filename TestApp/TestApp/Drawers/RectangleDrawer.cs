using System;

namespace TestApp.Drawers
{
    public class RectangleDrawer : Drawer
    {
        public RectangleDrawer(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"{name} drew a Rectangle");
        }
    }
}
