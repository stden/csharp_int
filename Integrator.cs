using System;
using System.Globalization;
using Functions;

namespace TrapInt {
    /// <summary>
    ///     Базовый класс для реализации метода трапеций с
    ///     фиксированным числом разбиения отрезка интегрирования
    ///     Класс должен иметь все виды конструкторов, деструктор (по необходимости),
    ///     свойства, методы реализации  соответствующего математического аппарата,
    ///     а также методы ввода с клавиатуры и вывода данных на экран
    /// </summary>
    public abstract class Integrator {
        public static CultureInfo culture = CultureInfo.InvariantCulture;
        public double A, B; // Интервал интегрирования [A,B]
        public double Eps; // Точность вычислений 
        protected IFunction F; // Функция для интегрирования
        public int N; // Разбиваем на N отрезков

        /// <summary>
        ///     Консольный ввод и вывод
        /// </summary>
        public Integrator(IFunction f) {
            F = f;
            Console.WriteLine(@"Пределы интегрирования:");
            Console.Write(@"  Начало: ");
            A = double.Parse(Console.ReadLine(), culture);
            Console.Write(@"  Конец: ");
            B = double.Parse(Console.ReadLine(), culture);
            Console.Write(@"  Точность результата: ");
            Eps = double.Parse(Console.ReadLine(), culture);
            Console.Write("Начальное число разбиений отрезка интегрирования: ");
            N = int.Parse(Console.ReadLine());
        }

        /// <summary>
        ///     Конструктор - инициализация параметров
        /// </summary>
        /// <param name="f">Функция для интегрирования</param>
        /// <param name="a">Начало интервала</param>
        /// <param name="b">Конец интервала</param>
        /// <param name="eps">Точность вычислений</param>
        /// <param name="n">Начальное число разбиений отрезка интегрирования</param>
        public Integrator(IFunction f, double a, double b, double eps, int n) {
            F = f;
            A = a;
            B = b;
            Eps = eps;
            N = n;
        }

        /// <summary>
        ///     Шаг интегрирования
        /// </summary>
        public double Step {
            get { return (B - A)/N; }
        }

        /// <summary>
        ///     Интегрирование одним из методов (метод определяется потомком)
        /// </summary>
        /// <returns>Значение интеграла</returns>
        public abstract double Integral();

        /// <summary>
        ///     Вывод в строчку
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Интеграл на интервале [" + A + "; " + B + "], N = " + N + ", F = " + F;
        }
    }

    /// <summary>
    ///     Вычисление интеграла методом трапеций
    ///     на заданном интервале [A, B]
    ///     используя число разбинений N
    /// </summary>
    /// <returns>Значение интеграла</returns>
    internal class TrapInt : Integrator {
        public TrapInt(IFunction f) : base(f) {
        }

        public TrapInt(IFunction f, double a, double b, double eps, int n)
            : base(f, a, b, eps, n) {
        }

        public override double Integral() {
            var h = Step; // Шаг интегрирования
            // Первая и последнее значение входят в 
            // сумму один раз => надо поделить на 2
            var s = (F.F(A) + F.F(B))/2.0; // Площадь (интеграл)
            for (var j = 1; j < N; j++)
                s += F.F(A + j*h); // Остальные по одному
            return h*s; // Умножаем на шаг чтобы получить интеграл
        }

        /// <summary>
        ///     Вычисление интеграла
        /// </summary>
        /// <returns></returns>
        public double Calc() {
            var Z1 = Integral();
            Console.WriteLine(ToString() + @"   eps = " + Eps);
            double curEps;
            do {
                // Удвоить число разбиений
                N *= 2;
                // Вычислить новое значение интеграла и сохранить в другой (например, Z2) переменной
                var Z2 = Integral();
                // С помощью имеющихся значений интеграла вычислить погрешность расчёта
                curEps = Math.Abs(Z1 - Z2);

                Console.WriteLine(@"N = {0}  Z1 = {1}  Z2 = {2}  |Z1-Z2| = {3}", N, Z1, Z2, curEps);

                // Если погрешность превышает указанное на входе значение eps, 
                // то присвоить значение Z2 переменной Z1,
                // удвоить число разбиений и снова вычислить Z2. 
                // В противном случае отобразить результат.
                Z1 = Z2;
            } while (curEps > Eps);
            Console.WriteLine();
            Console.WriteLine(@"РЕЗУЛЬТАТ:");
            Console.WriteLine(@"===========");
            Console.WriteLine(ToString());
            Console.WriteLine(@"Значение интеграла: " + Z1);
            Console.WriteLine(@"Размер полученного минимального шага интегрирования: " + Step);
            return Z1;
        }
    }
}