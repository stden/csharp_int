using System;
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
            switch (int.Parse(Console.ReadLine())) {
                case 1:
                    trapInt = new TrapInt(new MyFunc());
                    trapInt.Calc();
                    break;
                case 2:
                    Console.SetIn(new StreamReader("input.txt"));
                    Console.SetOut(new StreamWriter("result.txt"));
                    trapInt = new TrapInt(new MyFunc());
                    trapInt.Calc();
                    break;
            }
        }
    }
}