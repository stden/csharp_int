using System;
using TrapInt;

namespace Functions {
    public interface IFunction {
        /// <summary>
        ///     Функция для интегрирования
        /// </summary>
        /// <param name="x">Значение x</param>
        /// <returns>Значение функции</returns>
        double F(double x);
    }

    public class X2Func : IFunction {
        /// <summary>
        ///     Функция x^2
        /// </summary>
        /// <param name="x">Значение x</param>
        /// <returns>x^2</returns>
        public double F(double x) {
            return Math.Pow(x, 2.0);
        }

        /// <summary>
        ///     Неопределённый интеграл для x^2 (без константы)
        /// </summary>
        /// <param name="x">Значение x</param>
        /// <returns>x^3 / 3</returns>
        public double FInt(double x) {
            return Math.Pow(x, 3.0)/3.0;
        }

        public override string ToString() {
            return "f(x) = x^2";
        }
    }

    public class MyFunc : IFunction {
        /// <summary>
        ///     Параметр функции
        /// </summary>
        public double T;

        public MyFunc() {
            Console.Write(@"t = ");
            T = Convert.ToDouble(Console.ReadLine(), Integrator.culture);
        }

        public MyFunc(double t) {
            T = t;
        }

        public double F(double x) {
            return T*Math.Pow(x, 3)*Math.Cos(x + T)*Math.Tan(T*Math.Pow(x, 4));
        }

        public override string ToString() {
            return "f(x) = t * x^3 * cos(x+t) * tg(t * x^4), t = " + T;
        }
    }
}