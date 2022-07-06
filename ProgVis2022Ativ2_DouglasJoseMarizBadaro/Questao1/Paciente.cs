using System;

public class Paciente
{

    public String Nome { get; set; }
    public UInt64 Cns { get; set; }

    /*public Paciente() {

      Cns = String.Format(@"{0:000 0000 0000 0000}");
    }*/

    public override string ToString()
    {

        return ($"{Nome}, " + String.Format(@"{0:000 0000 0000 0000}", Cns));
    }
}