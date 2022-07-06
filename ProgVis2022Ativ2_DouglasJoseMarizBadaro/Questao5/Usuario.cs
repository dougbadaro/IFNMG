using System;

public class Usuario
{

    public String Nome { get; set; }
    public String Email { get; set; }
    public DateTime Nascimento { get; set; }
    public Byte Idade { get; set; }
    public Credencial Credencial { get; set; }

    public override String ToString()
    {

        TimeSpan Intervalo = DateTime.Now - Nascimento;
        Idade = Convert.ToByte(Math.Floor(Intervalo.TotalDays / 365.25));

        return ($"** Usuário **\n\nNome = {Nome}\nEmail = {Email}\nData de Nascimento = {Nascimento:dd/MM/yyyy}\nIdade = {Idade}\n\n** Credenciais **\n\nIdentificação = {Credencial.Identificacao}\nStatus = {(Credencial.Ativo ? "Ativo" : "Inativo")}\n");
    }
}