using System;

class Program
{
    public static void Main(string[] args)
    {

        ProcessarQuestao1();
        ProcessarQuestao2();
        ProcessarQuestao3();
        ProcessarQuestao4();
        ProcessarQuestao5();
    }

    public static void ProcessarQuestao1()
    {

        Paciente beatriz = new Paciente();
        beatriz.Nome = "Beatriz Yana";
        beatriz.Cns = 227683387130006;

        Console.WriteLine($"------------------------------\nResposta da Questão 1\n------------------------------\nObjeto: Paciente\nToString():\n\n{beatriz}\n\n");
    }

    public static void ProcessarQuestao2()
    {

        Eletrodomestico refrigerador = new Eletrodomestico();
        refrigerador.Codigo = 851796157395;
        refrigerador.Nome = "Refrigerador";
        refrigerador.Preco = 3253.12m;

        Console.WriteLine($"------------------------------\nResposta da Questão 2\n------------------------------\nObjeto: Paciente\nToString():\n\n{refrigerador}\n\n");
    }

    public static void ProcessarQuestao3()
    {

        Circulo circulo = new Circulo();
        circulo.Raio = 2.0;

        Quadrado quadrado = new Quadrado();
        quadrado.Lado = 2.0;

        Retangulo retangulo = new Retangulo();
        retangulo.LadoA = 2.0;
        retangulo.LadoB = 3.0;

        Losango losango = new Losango();
        losango.DiagonalA = 2.0;
        losango.DiagonalB = 3.0;

        Console.WriteLine($"------------------------------\nResposta da Questão 3\n------------------------------\nObjeto: Círculo\nToString():\n{circulo}\n\nObjeto: Quadrado\nToString():\n{quadrado}\n\nObjeto: Retângulo\nToString():\n{retangulo}\n\nObjeto: Losango\nToString():\n{losango}\n\n");
    }

    public static void ProcessarQuestao4()
    {

        Soma soma = new Soma();
        soma.ValorA = 2.5;
        soma.ValorB = -3.0;

        Subtracao subtracao = new Subtracao();
        subtracao.ValorA = 2.5;
        subtracao.ValorB = -3.0;

        Multiplicacao multiplicacao = new Multiplicacao();
        multiplicacao.ValorA = 2.5;
        multiplicacao.ValorB = -3.0;

        Divisao divisao = new Divisao();
        divisao.ValorA = 2.5;
        divisao.ValorB = -3.0;

        Console.WriteLine($"------------------------------\nResposta da Questão 4\n------------------------------\nObjeto: Soma\nToString():\n{soma}\n\nObjeto: Subtração\nToString():\n{subtracao}\n\nObjeto: Multiplicação\nToString():\n{multiplicacao}\n\nObjeto: Divisão\nToString():\n{divisao}\n\n");
    }

    public static void ProcessarQuestao5()
    {

        Credencial cLuis = new Credencial();
        cLuis.Identificacao = "luis.guisso";
        cLuis.Senha = "asdf123"; //Senha armazenada na memória como correta
        cLuis.Ativo = true;

        Usuario luis = new Usuario();
        luis.Credencial = cLuis;
        luis.Nome = "Luis Guisso";
        luis.Email = "luis.guisso@ifnmg.edu.br";
        luis.Nascimento = new DateTime(1982, 1, 1);

        Console.WriteLine($"------------------------------\nResposta da Questão 5\n------------------------------\nObjeto:Usuário\nToString():\n\n{luis}\n{(cLuis.Autenticar("asdf123") ? "Senha Correta!" : "Senha Incorreta!")}\n\n\n");

        //Teste com a Senha Incorreta.
        Credencial cDouglas = new Credencial();
        cDouglas.Identificacao = "douglas.badaro";
        cDouglas.Senha = "douglas00"; //Senha armazenada na memória como correta
        cDouglas.Ativo = false;

        Usuario douglas = new Usuario();
        douglas.Credencial = cDouglas;
        douglas.Nome = "Douglas Badaró";
        douglas.Email = "douglasbadaro@ifnmg.edu.br";
        douglas.Nascimento = new DateTime(2006, 1, 14);

        Console.WriteLine(douglas);
        Console.Write($"{(cDouglas.Autenticar("douglas77") ? "Senha Correta!" : "Senha Incorreta!")}");
    }
}