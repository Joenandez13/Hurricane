using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter wind speed: ");
    double speed = Convert.ToDouble(Console.ReadLine());

    
    if (speed >= 157){
      Console.WriteLine("Category Five Hurricane");
      }
    else if (speed >= 130) {
      Console.WriteLine("Category Four Hurricane");
      }
    else if (speed >= 111) {
      Console.WriteLine("Category Three Hurricane");
      }
    else if (speed >= 96) {
      Console.WriteLine("Category Two Hurricane");
      }
    else if (speed >= 74) {
      Console.WriteLine("Category One Hurricane");
      }
    else {
      Console.WriteLine("Not a Hurricane");
    }
  }
}