using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp;

public static class StringUtil
{
    public static string Half(this string s)
    {
        if (string.IsNullOrEmpty(s)) return string.Empty;

        // หาจุดกึ่งกลาง (หาร 2)
        int startIndex = s.Length / 2;

        // คืนค่าตั้งแต่จุดกึ่งกลางจนจบ String
        return s.Substring(startIndex);
    }
}

