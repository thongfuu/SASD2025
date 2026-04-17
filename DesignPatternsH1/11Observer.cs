using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsH1;

public class Subject
{
    public event Action<int>? MyEvent; // = delegate { };

    public void DoSomething()
    {
        // Do something 1
        MyEvent?.Invoke(5);
        // Do something 2
    }
}

public class Observer
{
    public Observer(Subject subject)
    {
        subject.MyEvent += Receive;
    }

    private void Receive(int n)
    { 
        Console.WriteLine("Receive event with value: " + n); 
    }
}
