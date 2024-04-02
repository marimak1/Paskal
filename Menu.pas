Program primer;
var
  n: integer;
  // раздел для объявления переменных. 
Begin
        // не УДАЛЯТЬ!! Организовано меню
     writeln ('введите номер задачи');
     Readln(n);
case n of

//вычисление функции вариант 1
1:
  Begin
    var sum, next: integer ;
    Writeln('Ведите числа с новой строки');
    Writeln('Введите 0 когда закончите введение');
    Readln(next);
    while next <> 0 do
    Begin
      sum := sum + next;
      Readln(next);
    end;
    Writeln('Сумма = ', sum);
  end;

//вычисление функции вариант 2
2:
  Begin
    var a,b,c:integer;
    Writeln('Введите cтороны треугольика a, b, c, каждое с новой строки');
    Readln(a,b,c);
    if (a+b <= c) or (a+c <= b) or (b+c <= a) then
      writeln('Треугольника с такими сторонами не существует')
    else if (Power(a, 2) = Power(b,2) + Power(c,2)) or (Power(b,2) = Power(a,2) + Power(c,2)) or (Power(c, 2) = Power(b,2) + Power(a,2)) then
      Writeln('Вы ввели стороны прямоугольного треугольника')
    else 
      Writeln('Это стороны не прямоугольного треугольника')
  end;
  //вычисление функции вариант 3
3:
  Begin 
  var f, y: double;
    Writeln('Введите y');
    Readln(y);
    if y > 2 then
      f := y+2
    else if y < 1 then
      f := Power(y,2) + 2*y + 0.3
    else
      f := Power(y,3) + Power(y,2)*2 + 0.3*y + 1;
    Writeln('f = ',f);
  end;
  //вычисление функции вариант 4
4:
  Begin
    var x, y: double;
    WriteLn('Введите координаты х и у точки на плоскости, каждое с новой строки');
    Readln(x, y);
    if ((y>=0) and (y<=2)) and ((x>=-1) and (x<=1)) then
      writeln('Точка с координатами ', x,', ', y,' находится в заштрихованной области')
    else writeln('Точка с координатами ', x,', ', y,' НЕ находится в заштрихованной области')
  end;
  //вычисление функции вариант 5
5:
  Begin
    var a,b,c,S: double;
    Writeln('Вычисление по формуле (a+b)/2*Sqrt(Power(c,2)- Power(a-b,2)/4)');
    writeln('Введите a,b,c');
    Readln(a,b,c);
    S := (a+b)/2*Sqrt(Power(c,2)- Power(a-b,2)/4);
    Writeln('Ответ: ',S);
  end;
//вычисление функции вариант 1
6:
  Begin 
    
  end;
  end;
  end.