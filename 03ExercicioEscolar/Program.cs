﻿using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome = "Dênis";
            a.nota1 = 8;
            a.nota2 = 9;
            a.mensagem();
        }
    }
}
