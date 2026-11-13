Program ProjectTrapInt;

// Вычисление значения интеграла по методу трапеций
// Программист Автор А.Ф.

{$AppType Console}

Uses SysUtils, Windows;

type real = extended; // Максимальная точность

var
  s1, s2, // Рабочие переменные
  x, // Переменная интегрирования
  a, b: real; // Пределы интегрирования
  n, k: integer; // Число разбиений, параметр цикла
  eps, eps1, h: real; // Погрешность, шаг интегрирования

function f(x: real): real;
begin
  result := 1.0 / sqrt(2 * x * x + 0.3);
end;

// Для вывода русских букв в старых Delphi
function Prompt(ps: PWideChar): PAnsiChar;
var
  bf: PAnsiChar;
begin
  GetMem(bf, Length(ps));
  CharToOem(ps, bf);
  result := bf;
end;

begin
  Write('Введите границы отрезка,' + #10'число разбиений и погрешность: ');
  ReadLn(a, b, n, eps);
  eps1 := 10 * eps;
  s2 := 0;
  while eps1 > eps do
  begin // R1
    s1 := s2;
    s2 := 0.5 * (f(b) + f(a));
    h := (b - a) / n;
    x := a + h;

    for k := 1 to n - 1 do
    begin
      s2 := s2 + f(x);
      x := x + h;
    end;
    eps1 := h * abs(s2 - 2 * s1) / 3;
    // Для просмотра динамики вычисления интеграла
    WriteLn('N = ', n, ' eps1 = ', eps1, #10' Int = ', h * s2);
    // ReadLn;
    n := 2 * n;
  end; // R1

  WriteLn(' Значение интеграла: ', h * s2:12, #10' с точностью ', eps:12);
  ReadLn;
end.
