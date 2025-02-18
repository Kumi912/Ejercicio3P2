using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantiad de agua potable que esta en su recibo"); //Pedimos al usuario que ingrese la cantidad de agua que esta en su recibo
        double agua = double.Parse(Console.ReadLine()); //Guardamos la cantidad de agua en la variable agua

        Agua consumo = new Agua(agua); //Creamos un objeto de la clase Agua

        Console.WriteLine("La cantidad de agua que consume su familia al mes es de " + consumo.CalcularConsumo() + " litros"); //Mostramos al usuario la cantidad de agua que consume su familia al mes
    }

    class Agua //Clase Agua
    {
        public double Agua1 { get; set; } //Propiedad de la clase agua

        public Agua(double agua) //Constructor de la clase Agua
        {
            Agua1 = agua;
        }

        public double CalcularConsumo() //Metodo para calcular el consumo de agua
        {
            return (Agua1 * 1000) / 2; //Calculamos el consumo de agua
        }
    }
}