using System;

public class Eletrodomestico
{

    public String Nome { get; set; }
    public UInt64 Codigo { get; set; }
    public decimal Preco { get; set; }

    public override string ToString()
    {
        return (String.Format(@"{0:00-0000-00000-0}", Codigo) + $", {Nome}, {Preco.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("pt-br"))}");
    }
}