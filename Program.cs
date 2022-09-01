using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine(" Selecione a opção desejada:\n" +
                        "1 - Adicionar Usuarios\n" +
                        "2 - Ver Usuários\n" +
                        "3 - Adicionar Cartão\n" +
                        "4 - Ver Cartões\n" +
                        "5 - Adicionar Despesas\n" +
                        "6 - Ver Despesas\n" +
                        "0 - SAIR\n");
                 opcao = int.Parse(Console.ReadLine());
                Usuariocs u1 = new Usuariocs();
                List<Usuariocs> usuarios = new List<Usuariocs>();
                switch (opcao)
                {

                    //ADICIONAR USUARIO
                    case 1:
                        usuarios.Add(u1);
                        Console.WriteLine("Informe o Nome: ");
                        u1.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF: ");
                        u1.Cpf = Console.ReadLine();
                        Console.WriteLine("Informe o Endereco: ");
                        u1.Endereco = Console.ReadLine();
                        Console.WriteLine("Informe o Telefone: ");
                        u1.Fone = Console.ReadLine();

                        break;

                    //MOSTRAR USUARIO
                    case 2:
                        for(int i = 0; i < usuarios.s)
                        Console.WriteLine(usuarios[].ToString());

                        break;



                }
                Console.ReadLine();
            }
            while (opcao != 0);
        }
    }
}
