using System;


class Program  {
  public static void Main (string[] args) {



   float Nota_1, Nota_2, Nota_3, Promedio;


            Console.WriteLine("Digite la nota 1:");
            Nota_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 2:");
            Nota_2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 3:");
            Nota_3 = float.Parse(Console.ReadLine());

            Promedio = (Nota_1 + Nota_2 + Nota_3) / 3;


            Console.WriteLine("El promedio es :" + Promedio);

            if (Promedio >= 3)
            {

                Console.WriteLine("El estudiante aprobo la asignatura");


            }
            else
            {
                Console.WriteLine("El estudiante reprobo la asignatura");

            }
  
  
  
  
  }
}