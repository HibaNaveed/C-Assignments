
using System;
class Table {
  static void Main() {
       Console.WriteLine("Enter Your Number");
      int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Table of"+" "+ num1);
      int num2=1;
      for(num2=1;num2<=10;num2++){
          Console.WriteLine(num1 + "*" + num2 +"="+ num1*num2);
      }
  }
}