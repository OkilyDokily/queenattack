using System;
using QueenAttack.Models;
namespace QueenAttack{
  public class Program{
    public static void Main(){
      Console.WriteLine("Enter a X axis value for a Queen");
      int x = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a Y axis value for a Queen");
      int y = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a X axis value for another piece");
      int x2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a Y axis value for another piece");
      int y2 = int.Parse(Console.ReadLine());

      Queen q =  new Queen(x,y);
      bool b = q.canAttackSpace(x2,y2);
      if(b){
        Console.WriteLine("The queen can attack that space.");
      }
      else{
        Console.WriteLine("The queen can't attack that space.");
      }
    }
  }
}