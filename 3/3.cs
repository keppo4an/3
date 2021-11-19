using System; 

public class Program {

  public static void Main(string[] args) {
    System.Console.OutputEncoding = System.Text.Encoding.UTF8;
    int a = int.Parse(Console.ReadLine());
    if (a<500 ) Console.WriteLine($"Цена составляет: {a}");
    else if ((a>500) && (a<=1000)) Console.WriteLine($"Цена составляет {a*0.97}");
    else Console.WriteLine($"Цена составляет {a*0.95}");
  }
}
