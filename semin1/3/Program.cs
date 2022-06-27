{
  int a;
  Console.WriteLine("введите число");
  a = int.Parse(Console.ReadLine());
  if (a % 2 == 0)
  {
     Console.Write("Введенное число является четным");
     Console.Read();
  }
   else
  {
      Console.Write("Введенное число нечетное");
      Console.Read();
  }
}

