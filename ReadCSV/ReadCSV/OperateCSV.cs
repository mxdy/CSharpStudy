using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ReadCSV
{
    class OperateCSV
    {
        public static void ReadFile(string path)
        {
            // 读取文件的源路径及其读取流
            StreamReader srReader = new StreamReader(path);

            // 读取流直到文件末尾结束
            while (!srReader.EndOfStream)
            {
                string strReadLine = srReader.ReadLine(); // 读取每行数据
                Console.WriteLine(strReadLine); // 打印每行数据
            }

            // 关闭读取流文件
            srReader.Close();
            Console.ReadKey();
        }

        // 新内容覆盖整个文件
        public static void WriteFile(string content,string path)
        {
            // 写入文件的源路径及其写入流
            StreamWriter swWriteFile = new StreamWriter(path, false);

            swWriteFile.WriteLine(content);
            Console.WriteLine("覆盖的新内容：", content);

            // 关闭流文件
            swWriteFile.Close();
            Console.ReadKey();
        }

        public static void AppendWrite(string content,string path)
        {
            // 写入文件的源路径及其写入流
            StreamWriter swWriteFile = new StreamWriter(path, true);

            swWriteFile.WriteLine(content);

            // 关闭流文件
            swWriteFile.Close();
            Console.WriteLine("追加的新内容：", content);
            Console.ReadKey();
        }
    }
}
