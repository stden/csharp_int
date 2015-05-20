﻿Курсовая работа по программированию на языках высокого уровня
-------------------------------------------------------------

**Тема:** Использование метода трапеций для вычисления значения определённого интеграла

1. Разработать базовый класс для реализации метода трапеций с фиксированным числом разбиения отрезка интегрирования.
Класс должен иметь все виды конструкторов, деструктор (по необходимости), свойства, методы реализации 
соответствующего математического аппарата, а также методы ввода с клавиатуры и вывода данных на экран.
2. С помощью базового класса создать наследника, реализующего вычисление интеграла методом трапеций с 
заданной точностью вычислений. 
В наследнике предусмотреть методы для ввода данных с клавиатуры и потока, а так же для вывода на экран и в поток. 
Тип потока выбрать по своему усмотрению.
3. Разработать структурированный алгоритм для консольного приложения. 
В качестве функции f(x) использовать:

  f(x) = t * x^3 * cos(x + t) tg (t * x^4 )
  
Предусмотреть ввод значений a, b, t и eps с клавиатуры и из потока. Выбор варианта ввода должен определять пользователь.
4. Закодировать разработанный алгоритм средствами языков C# и VB.
5. Разработать алгоритм для приложения управляемого событиями и реализовать его в C# и VB.
6. Для каждого типа приложения в качестве итога представить:
  * Значения всех введённых с клавиатуры параметров;
  * Вычисленное значение интеграла в наглядной форме;
  * Размер полученного минимального шага интегрирования;
  
Поскольку при данной постановке задачи необходимо получить результат с заданной точностью,
алгоритм должен предусматривать промежуточный контроль погрешности вычислений.
Такой контроль обеспечивается использованием формулы Рунге, 
для которой необходимо применять метод двойного пересчёта.

Значит, последовательность действий должна быть такой:
1. Ввести значения пределов интегрирования, точность результата и начальное число разбиений отрезка
интегрирования.
2. Вычислить значение интеграла при данном числе разбиений и сохранить итог в некоторой (например, Z1) переменной.
3. Удвоить число разбиений.
4. Вычислить новое значение интеграла и сохранить в другой (например, Z2) переменной.
5. С помощью имеющихся значений интеграла вычислить погрешность расчёта.
6. Если погрешность превышает указанной на входе значение, то присвоить значение Z2 переменной Z1,
удвоить число разбиений и снова вычислить Z2. В противном случае отобразить результат.

При реализации данного алгоритма вы можете отображать значение при каждом вычисленном числе разбиений
отрезка интегрирования или подсчитывать число итераций. 
Это позволит вам принять решение о целесообразности использования данного метода с точки зрения накладных расходов.
В предлагаемом ниже алгоритме предусмотрен вывод значений интеграла для каждого числа разбиений.


Блок-схемы
----------
* DrawAnywhere - http://www.drawanywhere.com/
* Gliffy - https://www.gliffy.com/
