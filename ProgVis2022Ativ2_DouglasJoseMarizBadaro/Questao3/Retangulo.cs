using System;

public class Retangulo
{

    public Double LadoA { get; set; }
    public Double LadoB { get; set; }

    public Double CalcularArea()
    {

        return LadoA * LadoB;
    }

    public override String ToString()
    {

        return ($"Lado A = {LadoA:F2}\nLado B = {LadoB:F2}\nÁrea = {CalcularArea():F2}");
    }
}