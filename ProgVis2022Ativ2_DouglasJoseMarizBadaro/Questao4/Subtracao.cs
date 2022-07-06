using System;

public class Subtracao
{

    public Double ValorA { get; set; }
    public Double ValorB { get; set; }

    public Double Operar()
    {

        return ValorA - ValorB;
    }

    public override String ToString()
    {

        return ($"Valor A = {ValorA:F1}\nValor B = {ValorB:F1}\nSubtração = {Operar():F1}");
    }
}