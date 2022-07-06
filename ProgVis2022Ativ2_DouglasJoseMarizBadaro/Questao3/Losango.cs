using System;

public class Losango
{

    public Double DiagonalA { get; set; }
    public Double DiagonalB { get; set; }

    public Double CalcularArea()
    {

        return (DiagonalA * DiagonalB) / 2;
    }

    public override String ToString()
    {

        return ($"Diagonal A = {DiagonalA:F2}\nDiagonal B = {DiagonalB:F2}\nÁrea = {CalcularArea():F2}");
    }
}