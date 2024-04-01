Program primer;
var
y,result:real;
a, b, c: integer;
num, sum: integer;
  n: integer; //не удалять!!! нужна для работы меню
  // раздел для объявления переменных. 
Begin
        // не УДАЛЯТЬ!! Организовано меню
     writeln ('введите номер задачи');
     Readln(n);
case n of

//вычисление функции вариант 1
1:
  Begin 
    sum := 0;

writeln('Введите числа: ');

repeat
readln(num);
sum := sum + num;
until num = 0;

writeln('Сумма равна: ', sum);

readln;
  end;

//вычисление функции вариант 2
2:
  Begin 
   writeln('Введите числа:');
readln(a, b, c);

if ((a * a + b * b = c * c) or
(a * a + c * c = b * b) or
(b * b + c * c = a * a)) then
writeln('Это стороны правильного треугольника')
else
writeln('Это стороны неправильного треугольника');

readln;
  end;
  //вычисление функции вариант 3
3:
  Begin 
    writeln('Введите число y:');
  readln(y);

  if y > 2 then
    result := y + 2
  else if y < 1 then
    result := y * y + 2 * y + 0.3
  else
    result := y * y * y + 2 * y * y + 0.3 * y + 1;

  writeln('Результат вычисления функции f(y) = ', result:0:2);
  end;
  //вычисление функции вариант 4
4:
  Begin 
    // сюда пишем код программы варианта
  end;
  //вычисление функции вариант 5
5:
  Begin 
    // сюда пишем код программы варианта
  end;
//вычисление функции вариант 1
6:
  Begin 
    // сюда пишем код программы варианта
  end;
  end;
  end.