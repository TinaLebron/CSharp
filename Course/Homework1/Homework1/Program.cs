using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //���using System;
            Console.ForegroundColor = ConsoleColor.Blue;//���using���r���C�⬰�Ŧ�
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System;");

            //���using System.Collections.Generic;
            Console.ForegroundColor = ConsoleColor.Blue;//���using���r���C�⬰�Ŧ�
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System.Collections.Generic;");

            //���using System.Linq;
            Console.ForegroundColor = ConsoleColor.Blue;//���using���r���C�⬰�Ŧ�
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System.Linq;");

            //���using System.Text;
            Console.ForegroundColor = ConsoleColor.Blue;//���using���r���C�⬰�Ŧ�
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System.Text;");

            //���using System.Threading.Tasks;
            Console.ForegroundColor = ConsoleColor.Blue;//���using���r���C�⬰�Ŧ�
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System.Threading.Tasks;");

            //���namespace ConsoleApp1
            Console.ForegroundColor = ConsoleColor.Blue;//���namespace���r���C�⬰�Ŧ�
            Console.Write("\nnamespace ");
            Console.ResetColor();
            Console.WriteLine("ConsoleApp1");

            //���{
            Console.WriteLine("{");

            //���class Program
            Console.ForegroundColor = ConsoleColor.Blue;//���class���r���C�⬰�Ŧ�
            Console.Write("\tclass ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Program");
            Console.ResetColor();

            //���{
            Console.WriteLine("\t{");

            //���static void Main(string[] args)
            Console.ForegroundColor = ConsoleColor.Blue;//���static void���r���C�⬰�Ŧ�
            Console.Write("\t\tstatic void ");
            Console.ResetColor();
            Console.Write("Main(");
            Console.ForegroundColor = ConsoleColor.Blue;//���string���r���C�⬰�Ŧ�
            Console.Write("string");
            Console.ResetColor();
            Console.WriteLine("[] args)");

            //���{
            Console.WriteLine("\t\t{");

            //���Console.WriteLine("Hello, world!");
            Console.ForegroundColor = ConsoleColor.Green;//���Console���r���C�⬰���
            Console.Write("\t\t\tConsole");
            Console.ResetColor();
            Console.Write(".WriteLine(");
            Console.ForegroundColor = ConsoleColor.Red;//���"Hello, world!"���r���C�⬰����
            Console.Write("\"Hello, world!\"");
            Console.ResetColor();
            Console.WriteLine(");");

            //���Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;//���Console���r���C�⬰���
            Console.Write("\t\t\tConsole");
            Console.ResetColor();
            Console.WriteLine(".ReadLine();");

            //���{
            Console.WriteLine("\t\t}");

            //���{
            Console.WriteLine("\t}");

            //���{
            Console.WriteLine("}");

            Console.ReadKey();
        }
    }
}
