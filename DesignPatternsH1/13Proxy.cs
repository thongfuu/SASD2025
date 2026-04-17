using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsH1;

public interface FileInterface
{
    public string Text { get; }
}

public class FileProxy : FileInterface
{
    RealFile? file = null;
    public string Text
    {
        get
        {
            if (file == null)
                file = new RealFile();

            return file.Text;
        }
    }
}

public class RealFile : FileInterface
{
    public string Text { get; }
    public RealFile()
    {
        Text = File.ReadAllText(@"C:\Windows\win.ini");
    }
}
