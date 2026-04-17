using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsH1;

public class MyMenuItemB
{
    Action command;
    public MyMenuItemB(Action command)
    {
        this.command = command;
    }
    public void Click()
    {
        command();
    }
}