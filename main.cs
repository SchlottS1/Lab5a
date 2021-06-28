using System;

class MainClass {
  public static void Main (string[] args) {
    double totalaverage = 0;
    for (int i = 1; i < 8; i++) 
    {
      Console.WriteLine("Enter the distance covered by car #" + i);
      double distance = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the time taken by car #" + i);
      double time = Convert.ToDouble(Console.ReadLine());
      double mph = distance / time;
      Console.WriteLine("The speed of this car is " + mph + " miles per hour");
      totalaverage = totalaverage + mph;
    }
    double average = totalaverage/7;
    Console.WriteLine("The average speed of the cars is " + average + " miles per hour");
  }
}