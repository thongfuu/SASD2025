using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101;

// 2
public class DuplicateCode
{
    string name = "Jimmy";
    public void Run()
    {
        PrintName("Owner");
        Console.WriteLine("...");
        PrintName("Signed");
    }
    private void PrintName(string label)
    {
        Console.WriteLine(label + " : " + name);
    }
}

