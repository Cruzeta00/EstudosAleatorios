using System;

class PessoaJuridica : Padrao
{
    // Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa empréstimo par Pessoa Jurídica R$ "+(valor * 0.2));
    }
}