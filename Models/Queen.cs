using System;

namespace QueenAttack.Models{
  public class Queen{
    public int X {get;}
    public int Y {get;}

    public Queen(int x, int y){
      X = x;
      Y = y;
    }

    private bool isDiagonal(int x, int y){
      if (Math.Abs((X - x)) == Math.Abs((Y - y))){
        return true;
      }
      return false;
    } 
    public bool canAttackSpace(int x, int y){
      if ((X == x) && (Y == y)) return false;
      if(X == x) return true;
      if(Y == y) return true;
      if (isDiagonal(x,y)) return true;
      return false;
    }
  }
}