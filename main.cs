/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld
{
  static void Main ()
  {
      Console.WriteLine("1. Sum\n2.Katet\n3.f(x)\n4.принадлежит ли точка А\n5.площадь равнобедренной трапеции\n6.значение переменных m и n ");
	Console.Write ("Enter number task:");
	int user_answer = Convert.ToInt32 (Console.ReadLine ());
	switch (user_answer)
	  {
	  case 1:
		task_1 ();
		break;
		case 2:task_2 ();
		break;
		case 3: task_3();
		break;
		case 4: task_4();
		break;
		case 5: task_5();
		break;
		case 6: task_6();
		break;
		default:
		Console.Write("Error");
		break;

	  }

  }

  public static void task_1 ()
  {
	int get_data_user = 1;
	int sum_data_user = 0;
	while (get_data_user != 0)
	  {
		Console.Write ("Enter number, if you want stop enter 0 :");
		get_data_user = Convert.ToInt32 (Console.ReadLine ());
		sum_data_user = sum_data_user + get_data_user;
	  }
	Console.WriteLine ($"Sum: {sum_data_user}");
  }

  public static void task_2 ()
  {
	Console.WriteLine ("Enter numb:");
	int a = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Enter numb:");
	int b = Convert.ToInt32 (Console.ReadLine ());
	Console.WriteLine("Enter numb:");
	int c = Convert.ToInt32 (Console.ReadLine ());

	if (a * a + b * b == c * c || a * a + c * c == b * b
		|| b * b + c * c == a * a)
	  {
		Console.WriteLine("Это катеты прямоугольного треугольника.");
	  }
	else
	  {
		Console.WriteLine("Это не катеты прямоугольного треугольника");
	  }
  }
  public static void task_3(){
    Console.WriteLine ("Enter numb:");
	double y = Convert.ToDouble(Console.ReadLine());
    if (y > 2){
        y = y + 2; 
        Console.WriteLine($"Y = {y}");
    }
    else if (y < 1){
        y = Math.Pow(y,2) + 2 * y + 0.3;
        Console.WriteLine($"Y = {y}");
    }
    else {
        y = Math.Pow(y,3) + 2 * Math.Pow(y,2) + 0.3 * y + 1;
         Console.WriteLine($"Y = {y}");
    } 
  }

    public static void task_4(){
    Console.WriteLine ("Enter x:");
	double x = Convert.ToDouble (Console.ReadLine ());
    Console.WriteLine("Enter y:");
	double y = Convert.ToDouble (Console.ReadLine ());
	if (x > 1 || x < -1 || y > 2 || y < 0 ){
	    Console.WriteLine("Не принадлежит");    
	}
	else {
	    Console.WriteLine("Принадлежит");
	}
	
    }
    
    public static void task_5(){
	Console.Write ("Enter numb:");
	double a = Convert.ToDouble (Console.ReadLine ());
    Console.Write("Enter numb:");
	double b = Convert.ToDouble (Console.ReadLine ());
	Console.Write("Enter numb:");
	double c = Convert.ToDouble (Console.ReadLine ());
	if (a == 0 || b == 0 || c == 0){
	    Console.WriteLine("Error");
	   }
	else {
	    double s = ((a + b ) / 2) * Math.Sqrt( Math.Pow(c,2) - (Math.Pow(a-b,2)/4 ));
	    Console.WriteLine(s);
	    }
    }
        
    public static void task_6(){
    Console.Write ("Enter numb:");
	double a = Convert.ToDouble (Console.ReadLine ());
    Console.Write("Enter numb:");
	double b = Convert.ToDouble (Console.ReadLine ());
	Console.Write("Enter numb:");
	double c = Convert.ToDouble (Console.ReadLine ());
	Console.Write ("Enter numb:");
	double d = Convert.ToDouble (Console.ReadLine ());
	double tmp = (a + (b * c -d))/d - (a *2);
	Console.WriteLine($"m/n = {tmp}");
    }    
    
}
