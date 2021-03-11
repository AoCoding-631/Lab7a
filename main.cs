using System;

class MainClass {

      //define function
    public static double IntegerPower()
    {
      double percentage = 0.0;
    //write code here to calculate the charges

      int CalculateCharge = DateTime.Today.Year;
      double nbrOfHours = CalculateCharge - percentage;

      if (nbrOfHours <= 3)
        percentage = 2.00;
      else if (nbrOfHours <= 24)
        percentage = 0.10;
      else
        percentage = 0.50;

      return percentage;
    }
    
    public static void Main (string[] args) {

      int CalculateCharge=0;
      //double nbrOfHours =0.0;
      double parking=0.0;
      int counter = 1;    
     
        Console.WriteLine("Enter the hours parked");
        double nbrOfHours = Convert.ToDouble(Console.ReadLine());
      
      while(counter <= CalculateCharge)
      {
        Console.WriteLine("Enter hours parked");
        CalculateCharge = Convert.ToInt32(Console.ReadLine());

        IntegerPower();

        parking = CalculateCharge * nbrOfHours;
        
        Console.WriteLine("Parking charge for this customer is " + CalculateCharge);
        counter++;
      }

      Console.WriteLine("All done") ;
    
    }  



  }