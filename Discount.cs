
using System;
class discount {
  static void Main() {
      int p1=500;
      int p2=3000;
      int p3=25000;
      int p4=5550;
      int p5=590;
      int price=p1+p2+p3+p4+p5;
      if(price>10000){
          
          int discount=(price*5/100);
             Console.WriteLine("Discount"+"="+ discount);
             Console.ReadLine();
             int total=(price-discount);
              Console.WriteLine("Total Price"+"="+ total);
              Console.ReadLine();
      }
      else{
           Console.WriteLine("No Discount");
            Console.ReadLine();
      }
  }
}