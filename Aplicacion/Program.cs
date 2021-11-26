using System;

namespace Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Controla tu peso, piensa en ti");
            float  Peso     = 0;
		float  Estatura = 0;	
		float  IMC	    = 0;
		String Estado   = "";
		Char   Opcion   = ' ';
		
		do{
			
		
			//Titulo de la Ventana
			Console.Title = "Calculo de IMC";
		
			//Solicitar Datos
			
			Console.WriteLine("Ingrese Peso");
			Peso = float.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese Altura");
			Estatura = float.Parse(Console.ReadLine());
			
			//Realizar Calculo
			
			IMC = (Peso/(Estatura * Estatura));
			
			//Determinar estado de la persona
			
			if (IMC < 16){
				Estado = "Delgadez Severa";
			}
			
			if ((IMC >= 16) && (IMC < 17)){
				Estado = "Delgadez Severa";
			}
			
			if ((IMC >= 17) && (IMC < 18.5)){
				Estado = "Delgadez Aceptable";
			}
			if ((IMC >= 18.5) && (IMC < 25)){
				Estado = "Peso Normal";
			}
            if ((IMC >= 25) && (IMC < 30)){
				Estado = "Sobrepeso";
			}
            if ((IMC >= 30) && (IMC < 35)){
				Estado = "Obesidad Tipo I";
			}
            if ((IMC >= 35) && (IMC < 40)){
				Estado = "Obesidad Tipo II";
			}
            if ((IMC >= 40) && (IMC < 50)){
				Estado = "Obesidad Tipo III o Mórbida";
			}
			if (IMC >= 50){
				Estado = "Obesidad Tipo IV o Extrema";
			}
			
			//Mostrar Resultado
			
			Console.WriteLine("Su IMC es de :" + IMC);
			Console.WriteLine("Su estado es :" + Estado);
			
			//Preguntar si repie calculo
			Console.WriteLine("Desea Continuar? (S = Si / N = No)");
			Opcion = Console.ReadKey(true).KeyChar;
			
		}while ((Opcion == 'S') || (Opcion == 's'));
		
        }
    }
}
