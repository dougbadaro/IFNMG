using System;

public class Credencial
{

    public String Identificacao { get; set; }
    public Boolean Ativo { get; set; }
    public String Senha { private get; set; }
    public Usuario Usuario { get; set; }

    public Boolean Autenticar(String senha)
    {

        if (senha == Senha)
        {

            return true;
        }
        else
        {

            return false;
        }
    }
}
