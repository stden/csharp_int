using System;
using System.Diagnostics;
using System.IO;
using Functions;

namespace TrapInt {
    internal static class Program {
        private static void test1() {
            // Тестируем работу на примере X^2
            var f = new X2Func();
            var func = new TrapInt(f, 1.0, 3.5, 1e-10, 10);
            Console.WriteLine(@"Определённый интеграл: {0}", f.FInt(func.B) - f.FInt(func.A));
            func.Calc();
        }

        private static void test2() {
            var trapInt = new TrapInt(new MyFunc(0.1), 0, 0.6, 1e-3, 32);
            trapInt.Calc();
        }

        /// <summary>
        ///     Основная программа
        /// </summary>
        [STAThread]
        public static void Main() {
            TrapInt trapInt;
            Console.WriteLine("Ввод данных: 1) с клавиатуры 2) из файла");
            Console.Write("Ваш выбор: ");
            try {
                switch (int.Parse(Console.ReadLine())) {
                    case 1:
                        trapInt = new TrapInt(new MyFunc());
                        trapInt.Calc();
                        Console.ReadLine();
                        break;
                    case 2:
                        var SaveIn = Console.In;
                        var SaveOut = Console.Out;
                        Console.SetIn(new StreamReader("input.txt"));
                        var sw = new StreamWriter("result.txt");
                        Console.SetOut(sw);
                        trapInt = new TrapInt(new MyFunc());
                        trapInt.Calc();
                        sw.Close();
                        Console.SetIn(SaveIn);
                        Console.SetOut(SaveOut);
                        Process.Start("notepad.exe", "result.txt");
                        break;
                }
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine("Файл \"" + ex.FileName + "\" отсутствует, создайте его в Блокноте!");
                using (var sw = new StreamWriter(ex.FileName)) sw.WriteLine("0.1\n0\n0.6\n1e-3\n32");
                Process.Start("notepad.exe", ex.FileName);
            }
        }
    }
}