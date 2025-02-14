using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantiad de agua potable que esta en su recibo"); //
        double agua = double.Parse(Console.ReadLine());

        Agua consumo = new Agua(agua);

        Console.WriteLine("La cantidad de agua que consume su familia al mes es de " + consumo.CalcularConsumo() + " litros");
    }

    class Agua
    {
        public double Agua1 { get; set; }

        public Agua(double agua)
        {
            Agua1 = agua;
        }

        public double CalcularConsumo()
        {
            return (Agua1 * 1000) / 2;
        }
    }
}