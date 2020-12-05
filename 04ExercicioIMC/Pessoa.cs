using System;

class Pessoa
{
    public double peso, altura;

    public double imc()
    {
        return (peso / (altura * altura));
    }

    public string situacao(double imc)
    {
        if(imc < 18.5) return "Abaixo do peso";
        else if(imc < 25) return "Peso normal";
        else if(imc < 30) return "Acima do Peso";
        else if(imc < 35) return "Obesidade I";
        else if(imc < 40) return "Obesidade II";
        else return "Obesidade III";
    }

    public void msg()
    {
        double obterImc = imc();
        string obterSituacao = situacao(obterImc);

        Console.WriteLine("Seu IMC é: "+obterImc+", "+obterSituacao);
    }
}