using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            OperateCSV.WriteFile("这是我追加的内容",@"../../files/file1.txt");
        }
    }
}
