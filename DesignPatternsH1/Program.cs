using System.Diagnostics;
using System.Numerics;
using CSharp;

namespace DesignPatternsH1;

internal class Program
{
    static void Main(string[] args)
    {
        //new DelegateSample().TestDelegate();
        //new DelegateSample().TestDelegate2();
        //new LightweightClass().Test();

        //TestObserver();
        TestCommand();
        //TestProxy();
        //TestDecorator();
        //TestChainOfResponsibility();
    }

    static void TestObserver()  // 11
    {
        Console.WriteLine("*********** Observer ***********");
        var subject = new Subject();
        var observer = new Observer(subject);
        subject.DoSomething();

        // Small
        var subject2 = new Subject();
        subject2.MyEvent += (n) => { Console.WriteLine("Receive event value n = " + n); };
        subject2.DoSomething();
    }

    static void TestCommand()   // 12
    {
        Console.WriteLine("*********** Command ***********");
        var menuItem = new MyMenuItem(new SaveCommand());
        menuItem.Click();

        // Small (use delegate)
        var menuItem2 = new MyMenuItemB(() => Console.WriteLine("Small Command"));
        menuItem2.Click();
    }

    static void TestProxy()     // 13
    {
        Console.WriteLine("*********** Proxy ***********");
        FileInterface file = new FileProxy();
        Console.WriteLine(file.Text);
    }

    static void TestDecorator() // 14
    {
        Console.WriteLine("*********** Decorator ***********");
        PersonInterface person = new Person("John Black");
        PersonInterface personB = new DashDecorated(person);
        PersonInterface personC = new StarDecorated(person);
        PersonInterface personD = new DashDecorated(personC);

        Console.WriteLine(person.PrintedName);
        Console.WriteLine(personB.PrintedName);
        Console.WriteLine(personC.PrintedName);
        Console.WriteLine(personD.PrintedName);

        //---------------------------------------

        // Decorator Pattern in FileInputStream in "Java"
        // InputStream inFile = new BufferedInputStream(new FileInputStream("data.txt"));
    }
    static void TestChainOfResponsibility() // 15
    {
        Console.WriteLine("*********** Chain of Responsibility ***********");
        var root = new Widget(new Widget(new Button(new Widget(null))));
        root.MouseDown(new Vector2(50, 50));
    }
}
