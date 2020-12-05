using System;

class PessoaFisica : Padrao
{
    // Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa empréstimo par Pessoa Física R$ "+(valor * 0.1));
    }
}