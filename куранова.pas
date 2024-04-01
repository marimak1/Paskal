Program primer;
var
  n: integer; a: integer; b: integer ; s: integer; c: integer;
  x: INTEGER; y: integer;
  //не удалять!!! нужна для работы меню
  // раздел для объявления переменных. 
Begin
        // не УДАЛЯТЬ!! Организовано меню
     writeln ('введите номер задачи');
     Readln(n);
case n of

//вычисление функции вариант 1
1:


  Begin 
    // сюда пишем код программы варианта
    Writeln('введите а');
    Readln(a);
    Writeln('введите b');
    Readln(b);
    s:=a+b;
    Writeln ('ответ ', s)
  end;

//вычисление функции вариант 2
2:
  Begin 
    // сюда пишем код программы варианта
    Writeln('введите а');
    Readln(a);
    Writeln('введите b');
    Readln(b);
    Writeln('введите c');
    Readln(c);
    if (a+b<=c)or(a+c<=b)or(b+c<=a)then
  writeln('Это не треугольник!')
  else if (a=b)and(b=c)then writeln('Это равносторонний треугольник!')
  else if ((a=b)and(b<>c))or((a=c)and(b<>c))or((b=c)and(a<>c))
  then writeln('Это равнобедренный треугольник!')
  else  write('Это произвольный треугольник');
  end;
  //вычисление функции вариант 3
3:
  Begin 
    // сюда пишем код программы варианта
    write('y = ');
    readln(y);

    if y > 2 then
        x:=y+2;

    writeln('y = ', y);
  end
  end;
  end.