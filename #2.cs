using System;

class Program {
  public static void Main (string[] args) {

    String Genero;
            float Edad;
            float Pulsaciones;
          
            Console.WriteLine("DIGITE EN MAYUSCULA MASCULINO/FEMENINO (M/F)");
            Genero = Console.ReadLine();

            if ((Genero == "M") || (Genero =="m"))
            {
                Console.WriteLine("SU GENERO ES ---> MASCULINO  ");
                Console.WriteLine("DIGITE SU EDAD : ");
                Edad = float.Parse(Console.ReadLine());
                Pulsaciones = ((210 - Edad)) / 10;
                Console.WriteLine("SU NUMERO DE PULSACIONES ES DE : " + Pulsaciones);

            }


            else if ((Genero == "F") || (Genero =="f"))
            {
                Console.WriteLine("SU GENERO ES ---> FEMENINO  ");
                Console.WriteLine("DIGITE SU EDAD : ");
                Edad = float.Parse(Console.ReadLine());
                Pulsaciones = ((220 - Edad)) / 10;
                Console.WriteLine("SU NUMERO DE PULSACIONES ES DE : " + Pulsaciones);

            }


  }
}