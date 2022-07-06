using System;

public class Quadrado
{

    public Double Lado { get; set; }

    public Double CalcularArea()
    {

        return Math.Pow(2, Lado);
    }

    public override string ToString()
    {

        return ($"Lado = {Lado:F2}\nÁrea = {CalcularArea():F2}");
    }
}