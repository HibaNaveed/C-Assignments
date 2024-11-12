
using System;
class calculator {
  static void Main() {
       Console.WriteLine("Enter First Number");
      double num1= Convert.ToDouble(Console.ReadLine());
    //   Console.WriteLine(num1);
        Console.WriteLine("Enter Operator");
      string op=Console.ReadLine();
         Console.WriteLine("Enter Second Number");
      double num2= Convert.ToDouble(Console.ReadLine());
    //   Console.WriteLine(num2);
       if(op=="+"){
      double addition= num1+num2;
        Console.WriteLine(num1 +"+"+ num2+"="+ addition);
         Console.ReadLine();
      }
      if(op=="-"){
      double sub= num1-num2;
        Console.WriteLine(num1 +"-"+ num2+"="+ sub);
         Console.ReadLine();
      }
      if(op=="*"){
      double mul= num1*num2;
        Console.WriteLine(num1 +"*"+ num2+"="+ mul);
         Console.ReadLine();
      }
      if(op=="/"){
      double div= num1/num2;
        Console.WriteLine(num1 +"/"+ num2+"="+ div);
         Console.ReadLine();
      }
      if(op=="%"){
      double rem= num1%num2;
        Console.WriteLine(num1 +"%"+ num2+"="+ rem);
         Console.ReadLine();
      }
      else{
           Console.WriteLine("Enter Valid Operator");
      }
       Console.ReadLine();
  }
}