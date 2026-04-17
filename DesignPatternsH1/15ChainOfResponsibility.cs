using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsH1;

public class Widget
{
    protected Widget? child;
    public Widget(Widget? child) => this.child = child;
    public virtual void MouseDown(Vector2 position) { child?.MouseDown(position); }
}

public class Button : Widget
{
    public Button(Widget? child) : base(child)
    {
    }

    public override void MouseDown(Vector2 position)
    {
        if (position.X <= 100 && position.Y <= 100)
            Console.WriteLine("BUTTON: Process mouse event"); // do something
        else
            base.MouseDown(position);
    }
}
