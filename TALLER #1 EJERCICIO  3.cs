using System;

class MainClass {

  
  public static void Main (string[] args) {


      
      string Nombre_Usuario,Numero_De_Cuenta;
      int Monto_Inicial,ValorAConsignar,ValorARetirar,SaldoFinal,Opcion;



    Console.WriteLine ("*******TRANSACCIONES EL CONDOR EXPRESS*******");
    Console.WriteLine (" ********BIENVENIDO SR USUARIO******** ");
    
  
    
    Console.WriteLine ("POR FAVOR INGRESE EL  NOMBRE DEL TITULAR :");
    Nombre_Usuario=Console.ReadLine();
    Console.WriteLine ("POR FAVOR INGRESE UN NUMERO PARA SU CUENTA :");
    Numero_De_Cuenta=Console.ReadLine();
    Console.WriteLine ("EL MONTO INICIAL PARA SU CUENTA :");
    Monto_Inicial=int.Parse(Console.ReadLine());
    

    Console.WriteLine ("SELECCIONE LA OPCION QUE DESEA REALIZAR :");
    Console.WriteLine ("___________________________");
    Console.WriteLine ("| ---->   1.CONSIGNACCION  |");
    Console.WriteLine ("| ---->   2.RETIRO         |" );
    Console.WriteLine ("| ---->   3.SALIR          |");
    Console.WriteLine ("|__________________________|");
    
   Console.WriteLine ("SELECCIONE LA OPCION QUE DESEA REALIZAR :");
  
   Opcion=int.Parse(Console.ReadLine());
    
  if(Opcion==1){
    Console.WriteLine ("SR(A) "+Nombre_Usuario +" DIGITE EL VALOR DE SU CONSIGNACION:");
    ValorAConsignar=int.Parse(Console.ReadLine());
    SaldoFinal=Monto_Inicial+ValorAConsignar;
    Console.WriteLine ("SR(A) "+Nombre_Usuario +" SU SALDO FINAL ES DE :"+SaldoFinal);
    Console.WriteLine ("DESEA CONTINUAR SI--> S/N --> NO");
    string Opcion2 =Console.ReadLine();


      if((Opcion2=="S")||(Opcion2=="s")){
                    Console.WriteLine ("SELECCIONE LA OPCION QUE DESEA REALIZAR :");
                    Console.WriteLine ("___________________________");
                    Console.WriteLine ("| ---->   1.CONSIGNACCION  |");
                    Console.WriteLine ("| ---->   2.RETIRO         |" );
                    Console.WriteLine ("| ---->   3.SALIR          |");
                    Console.WriteLine ("|__________________________|");

                  Console.WriteLine ("SELECCIONE LA OPCION QUE DESEA REALIZAR :");
                  Opcion=int.Parse(Console.ReadLine());

          
             if(Opcion==1){
                Console.WriteLine ("SR "+Nombre_Usuario +" DIGITE EL VALOR DE SU CONSIGNACION:");
                ValorAConsignar=int.Parse(Console.ReadLine());
                SaldoFinal=SaldoFinal+ValorAConsignar;
                Console.WriteLine ("SR(A) "+Nombre_Usuario +" SU SALDO FINAL ES DE :"+SaldoFinal);
                Console.WriteLine ("DESEA CONTINUAR SI--> S/N --> NO");
               




            }else if (Opcion==2) {
              Console.WriteLine ("SR "+Nombre_Usuario +" DIGITE EL VALOR DE SU RETIRO: ");
                ValorARetirar=int.Parse(Console.ReadLine());
                SaldoFinal=SaldoFinal-ValorARetirar;
                Console.WriteLine ("SR(A)"+Nombre_Usuario +" SU SALDO FINAL ES DE :"+SaldoFinal);
                Console.WriteLine ("DESEA CONTINUAR SI--> S/N --> NO");
                
            


                  }


  }else if((Opcion2=="N") || (Opcion2=="n")){


Console.WriteLine ("HASTA LA PROXIMA SR(A) --->"+Nombre_Usuario+"");


  }

                
}
else if (Opcion==2) {
              Console.WriteLine ("SR(A) "+Nombre_Usuario +" DIGITE EL VALOR DE SU RETIRO: ");
                ValorARetirar=int.Parse(Console.ReadLine());
                SaldoFinal=Monto_Inicial-ValorARetirar;
                Console.WriteLine ("SR "+Nombre_Usuario +" SU SALDO FINAL ES DE :"+SaldoFinal);
                Console.WriteLine ("DESEA CONTINUAR SI--> S/N --> NO");
                string Opcion2 =Console.ReadLine();


                    if((Opcion2=="S")||(Opcion2=="s")){
                    Console.WriteLine ("SELECCIONE LA OPCION QUE DESEA REALIZAR :");
                    Console.WriteLine ("___________________________");
                    Console.WriteLine ("| ---->   1.CONSIGNACCION  |");
                    Console.WriteLine ("| ---->   2.RETIRO         |" );
                    Console.WriteLine ("| ---->   3.SALIR          |");
                    Console.WriteLine ("|__________________________|");

                  Console.WriteLine ("SELECCIONE LA OPCION QUE DESEA REALIZAR :");
                  Opcion=int.Parse(Console.ReadLine());


                  if(Opcion==1){
                  Console.WriteLine ("SR "+Nombre_Usuario +" DIGITE EL VALOR DE SU CONSIGNACION:");
                  ValorAConsignar=int.Parse(Console.ReadLine());
                  SaldoFinal=SaldoFinal+ValorAConsignar;
                  Console.WriteLine ("SR(A) "+Nombre_Usuario +" SU SALDO FINAL ES DE :"+SaldoFinal);
                  Console.WriteLine ("DESEA CONTINUAR SI--> S/N --> NO");

                  }else if (Opcion==2) {
                  Console.WriteLine ("SR "+Nombre_Usuario +" DIGITE EL VALOR DE SU RETIRO: ");
                  ValorARetirar=int.Parse(Console.ReadLine());
                  SaldoFinal=SaldoFinal-ValorARetirar;
                  Console.WriteLine ("SR(A)"+Nombre_Usuario +" SU SALDO FINAL ES DE :"+SaldoFinal);
                  Console.WriteLine ("DESEA CONTINUAR SI--> S/N --> NO");
                
            


                  }


  }else if((Opcion2=="N") || (Opcion2=="n")){


Console.WriteLine ("HASTA LA PROXIMA SR(A) --->"+Nombre_Usuario+"");


  }








  }


  


}

}
