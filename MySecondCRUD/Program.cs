//inicio do CRUD (Create, Read, Update, Delete): O objetivo dessa atividade é programar um algoritimo CRUD completo.
//Para este algoritimo irei utilizar o Excel para armazenar os dados e uma biblioteca de classes C# para fazer buscas
//atualizações, deleções e inserir os dados na planilha.
using System;
using System.ComponentModel;
using System.Drawing;
using Console = Colorful.Console;

namespace MySecondCRUD {
    public class Program {
        //Variaveis de escopo global
        public static int[] Lista = new int[20];
        public static string Mensagem = "";
        public static Color MensagemColor = Color.Red;

        public static void Main() {
            //variaveis de escopo local
            bool Pass;
            bool Passe;
            char NumOp;
            int num;

            //inicio do programa
            Console.Clear();
            Logo.Titulo();

            if (Mensagem.Length <= 0)
            {
                Console.WriteLine("\n\n  Olá Usuario, Este é o sistema CRUD (Create, Read, Update, Delete) de Marcondes Paixão.",
                color: Color.DarkCyan);
            }
            else
            {
                Console.WriteLine("\n\n  Querido Usuario, " + Mensagem, color: MensagemColor);
            }
            Console.WriteLine("\n  Digite um Numero para selecionar opção desejada:\n",
                color: Color.DarkCyan);

            Console.Write("  ["); Console.Write("1", Color.DarkMagenta); Console.Write("]");
            Console.Write(" Inserir\n");
            Console.Write("  ["); Console.Write("2", Color.DarkMagenta); Console.Write("]");
            Console.Write(" Remover\n");
            Console.Write("  ["); Console.Write("3", Color.DarkMagenta); Console.Write("]");
            Console.Write(" Imprimir\n");
            Console.Write("  ["); Console.Write("4", Color.DarkMagenta); Console.Write("]");
            Console.Write(" Substituir\n");
            Console.Write("  ["); Console.Write("5", Color.DarkMagenta); Console.Write("]");
            Console.Write(" Sair\n");

            Console.Write("\n  C/: ");
            Pass = char.TryParse(Console.ReadLine(),out NumOp);

            if (Pass == true) {
                Mensagem = "";
                Logo.ResetarCorDaLogo();

                switch (NumOp) {
                    case '1':
                        Console.Clear();

                        Console.WriteLine("  Digite um valor inteiro: ");
                        Console.Write("\n  C/: ");

                        Passe = int.TryParse(Console.ReadLine(),out num);

                        if (Passe) {
                            Funcoes.Inserir(num);
                        }
                        else {
                            Mensagem = "Digete um valor INTEIRO !!!!";
                            MensagemColor = Color.Red;
                            Logo.SegundaCorDaLogo();
                            Main();
                        }
                        break;

                    case '2':
                        Console.Clear();

                        Console.WriteLine("  Digite o Numero da linha que deseja Deletar: ");
                        Console.Write("\n  C/: ");

                        Passe = int.TryParse(Console.ReadLine(), out num);

                        if (Passe && num <= 20 && num > 0)
                        {
                            Funcoes.Remover(num);
                        }
                        else
                        {
                            Mensagem = "Posição invalida";
                            MensagemColor = Color.Red;
                            Logo.SegundaCorDaLogo();
                            Main();
                        }

                        break;

                    case '3':
                        Funcoes.Imprimir();
                        break;

                    case '4':
                        int num2;
                        bool Passe2;

                        Console.Clear();

                        Console.WriteLine("  Digite o Numero da linha que deseja Substituir: ");
                        Console.Write("\n  C/: ");

                        Passe = int.TryParse(Console.ReadLine(), out num);

                        Console.WriteLine("  Digite o valor que deseja inserir no lugar dele: ");
                        Console.Write("\n  C/: ");

                        Passe2 = int.TryParse(Console.ReadLine(), out num2);

                        if (Passe && Passe2 && num <= 20 && num > 0)
                        {
                            Funcoes.Substituir(num2, num);
                        }
                        else
                        {
                            Mensagem = "Digete um valor INTEIRO !!!!";
                            MensagemColor = Color.Red;
                            Logo.SegundaCorDaLogo();
                            Main();
                        }
                        break;

                    case '5':
                        Funcoes.Sair();
                        break;

                    default:
                        Mensagem = "Você selecionou uma opção que não existe !";
                        MensagemColor = Color.Red;
                        Logo.SegundaCorDaLogo();
                        Main();
                        break;
                }
            }
            else {
                Mensagem = "Você selecionou uma opção que não existe !";
                MensagemColor = Color.Red;
                Logo.SegundaCorDaLogo();
                Main();
            }
        }
    } 
}
