using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsH1;

public class LightweightClass
{
    public void Test()
    {
        // Using Delegates like lightweight classes
        Func<string, string> func1 = name => "Greeting, " + name;
        Func<string, string> func2 = name => "Hello, " + name;

        Func<string, string> f = func2;
        Console.WriteLine(f("John"));
    }
}

//************* Heavy Weight Classes *******************
public interface Greeting
{
    public string Message { get; }
}

public class Greeting1 : Greeting
{
    string name;
    public Greeting1(string name) => this.name = name;
    public string Message => "Greeting, " + name;
}
public class Greeting2 : Greeting
{
    string name;
    public Greeting2(string name) => this.name = name;
    public string Message => "Hello, " + name;
}
