using System;

public class Circulo
{
    public Double Raio { get; set; }

    public Double CalcularArea()
    {
        return 3.14159 * Math.Pow(2, Raio);
    }

    public override string ToString()
    {

        return ($"Raio = {Raio:F2}\nÁrea = {CalcularArea():F3}");
    }
}