
using System;
class Assignment {
  static void Main() {
    Console.WriteLine("Can you find vegetable in the market?");
    bool veg= Convert.ToBoolean(Console.ReadLine());
    if(!veg){
        Console.WriteLine("Vegetable not found. Going to buy meat");
    }
    else{
        Console.WriteLine("Vegetable found");
        return;
    }
    Console.WriteLine("Can you find Meat in the market?");
     bool meat= Convert.ToBoolean(Console.ReadLine());
     if(!meat){
        Console.WriteLine("Meat not found. Going to the Mart");
    }
    else{
        Console.WriteLine("Meat found");
        return;
    }
    Console.WriteLine("In the Mart");
        Console.WriteLine("Vegetable price");
     int pveg=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Meat price");
      int pmeat=Convert.ToInt32(Console.ReadLine());
       int price=pveg+pmeat;
        Console.WriteLine("Your Bill is "+" "+ price);
    if(price<17000){
     Console.WriteLine("Bill is below 17,000. Paying 50% with card and 50% with cash.");
            int cardPayment = price / 2;
            int cashPayment = price / 2;
             Console.WriteLine("Card Payment amount is "+":"+cardPayment);
              Console.WriteLine("Cash Payment amount is "+":"+cashPayment);
        }
        else if(price>17000 && price<50000){
            Console.WriteLine("Bill is above 17,000. Paying all with card except 5,000.");
            int amount=price-5000;
            Console.WriteLine("Card Payment amount is "+":"+amount);
              Console.WriteLine("Cash Payment amount is "+":"+"5,000");
        }
        else if(price==50000){
            int discount=price*75/100;
            int totalamount= price-discount;
              Console.WriteLine("Discounted price "+":"+discount);
             Console.WriteLine("Total Bill is "+":"+totalamount);
        }
        else{
             Console.WriteLine("Enter Valid Number");
        }
    }
  }
