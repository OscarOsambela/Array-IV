using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
		//8.instanciar el array
    int[] arrElementos = LeerDatos();
    Console.WriteLine("Imprimiendo desde el main");
    //9.recorrer cada elemento del array
		foreach(int i in arrElementos){
      Console.WriteLine(i);
    }
  } 
	//1. crear método
  public static int[] LeerDatos(){
    Console.WriteLine("Cuántos elementos quiere que tenga el array?");
		//2.capturar la respuesta con readline()
    int respuesta = int.Parse(Console.ReadLine());
		//3.instanciar el array
    int [] datos = new int[respuesta];
		//4.manejar los datos del array con for
    for(int i=0; i<respuesta; i++){
      Console.WriteLine($"Introduce el dato para la posición {i}");
			//5.capturar la respuesta 
      int respuestaPosicion = int.Parse(Console.ReadLine());
			//6. declarar el array con los datosrecibidos en la respuesta
      datos[i] = respuestaPosicion;
    }
		//7.retornar los valores del array
    return datos;
  }

}
 