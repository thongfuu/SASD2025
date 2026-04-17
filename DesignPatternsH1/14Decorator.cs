using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsH1;

public interface PersonInterface
{
    public string PrintedName { get; }
}

public class Person : PersonInterface
{
    public string PrintedName { get; }

    public Person(string name)
    {
        PrintedName = name + "\n";
    }
}

public class DashDecorated : PersonInterface
{
    PersonInterface person;
    public DashDecorated(PersonInterface person)
    {
        this.person = person;
    }

    public string PrintedName => "----------\n" + person.PrintedName + "----------\n";
}
public class StarDecorated : PersonInterface
{
    PersonInterface person;
    public StarDecorated(PersonInterface person)
    {
        this.person = person;
    }

    public string PrintedName => "**********\n" + person.PrintedName + "**********\n";
}

