using System;

class Program {

 static int SaldoFinal,Monto_Inicial,ValorAConsignar,ValorARetirar,controlOpcion,Monto_Parcial;
 static string  ControlWhile, Nombre_Usuario,Numero_De_Cuenta;

  public static void Main (string[] args) {
    
    presentacion();
    

  }
 

  static void presentacion(){

  
    
    
    Console.WriteLine("SR USUARIO DIGITE SU NOMBRE:");
    Nombre_Usuario=Console.ReadLine();
    Console.WriteLine ("POR FAVOR INGRESE UN NUMERO PARA SU CUENTA :");
    Numero_De_Cuenta=Console.ReadLine();
    Console.WriteLine ("EL MONTO INICIAL PARA SU CUENTA :");
    Monto_Inicial=int.Parse(Console.ReadLine());

    operaciones(controlOpcion);
    
   

}

 static void operaciones (int controlOpcion){

             do{

              Console.WriteLine ("SELECCIONE LA OPCION QUE DESEA REALIZAR :");
              Console.WriteLine ("___________________________");
              Console.WriteLine ("| ---->   1.CONSIGNACCION  |");
              Console.WriteLine ("| ---->   2.RETIRO         |" );
              Console.WriteLine ("| ---->   3.SALIR          |");
              Console.WriteLine ("|__________________________|");
    
              Console.WriteLine ("SELECCIONE LA OPCION QUE DESEA REALIZAR :");

              controlOpcion=int.Parse(Console.ReadLine());



if (controlOpcion==1){

  Console.WriteLine ("DIGITE EL VALOR QUE DESEA CONSIGNAR");
  ValorAConsignar=int.Parse(Console.ReadLine());
  SaldoFinal=Monto_Inicial+ValorAConsignar;
  Console.WriteLine ("SU SALDO ACTUAL ES DE:  "+SaldoFinal);
  Monto_Inicial=SaldoFinal;

}else if (controlOpcion==2){
  Console.WriteLine ("DIGITE EL VALOR QUE DESEA RETIRAR");
  ValorARetirar=int.Parse(Console.ReadLine());
  SaldoFinal=Monto_Inicial-ValorARetirar;
  Console.WriteLine ("SU SALDO ACTUAL ES DE:  "+SaldoFinal);
  Monto_Inicial=SaldoFinal;

}else if(controlOpcion==3){

 Console.WriteLine (" HASTA LA PROXIMA SR(A): "+Nombre_Usuario);
 
}

Console.WriteLine ("SELECCION S/N SI DESEA O NO CONTINUAR " );

ControlWhile=Console.ReadLine();



}while((ControlWhile=="S") || (ControlWhile=="s"));
                
            } 

    






}
