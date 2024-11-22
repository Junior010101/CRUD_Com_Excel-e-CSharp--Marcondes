using ClosedXML.Excel;
using System.Drawing;
using Console = Colorful.Console;
using Colorful;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using Color = System.Drawing.Color;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace MySecondCRUD {
    internal class Funcoes {
        //local do arquivo
        private static string arquivo = Path.GetFullPath(@"..\..\..\BancoDeDados.xlsx");

        //Função para inserir dados na ultima linha da tabela
        public static void Inserir(int num) {

            using (var workbook = new XLWorkbook(arquivo))
            {
                var excWs = workbook.Worksheet("Banco de Dados");
                var UltimaLinha = excWs.LastRowUsed()?.RowNumber() ?? 1;

                if (UltimaLinha != 21)
                {
                    var NovaLinha = UltimaLinha + 1;

                    excWs.Cell(NovaLinha, 1).Value = num;

                    workbook.SaveAs(arquivo);

                    Program.Mensagem = $"Você Inseriu com sucesso o item [{num}] na coluna $A{UltimaLinha + 1}";
                    Program.MensagemColor = Color.Green;
                    Program.Main();
                }
                else {
                    Program.Mensagem = "Você não pode inserir mais itens pois a lista está cheia !";
                    Program.MensagemColor = Color.Red;
                    Logo.SegundaCorDaLogo();
                    Program.Main();
                }
            }
        }

        //função que remove determinado item de acordo com o numero da linha
        public static void Remover(int Linha)
        {
            using (var workbook = new XLWorkbook(arquivo))
            {
                var excWs = workbook.Worksheet("Banco de Dados");

                var DelLinha = excWs.RowsUsed().Skip(1).FirstOrDefault(r => r.Cell(1).GetValue<int?>() == Linha);

                if (DelLinha != null)
                {
                    DelLinha.Delete();
                    workbook.SaveAs(arquivo);

                    Program.Mensagem = $"Você Deletou com sucesso o item presente na coluna $A{Linha}";
                    Program.MensagemColor = Color.Green;
                    Program.Main();
                }
                else
                {
                    Program.Mensagem = "A Linha que você deseja deletar, ja está vazia";
                    Program.MensagemColor = Color.Red;
                    Logo.SegundaCorDaLogo();
                    Program.Main();
                }
            }
        }

        public static void Imprimir()
        {
            Console.Clear();

            using (var workbook = new XLWorkbook(arquivo))
            {
                var excWs = workbook.Worksheet("Banco de Dados");

                int index = 1;
                foreach (var row in excWs.RowsUsed().Skip(1))
                {
                    index++;
                    Console.WriteLine($"  {index} - " + (int)row.Cell(1).GetValue<int>());
                }
            }

            Console.WriteLine("\nPrecione qualquer tecla para voltar...");
            Console.ReadKey();

            Program.Main();
        }

        public static void Substituir(int valor, int index)
        {
            using (var workbook = new XLWorkbook(arquivo))
            {
                var excWs = workbook.Worksheet("Banco de Dados");

                excWs.Cell(index, 1).Value = valor;

                workbook.SaveAs(arquivo);

                Program.Mensagem = $"Você Substituiu com sucesso o valor da linha {index} pelo valor {valor}";
                Program.MensagemColor = Color.Green;
                Program.Main();
            }
        }
        public static void Sair() {
            bool Pass;
            char NumOp;

            Console.Clear();

            Console.WriteLine("\n  Você deseja sair ?\n");
            Console.Write("  ["); Console.Write("1", Color.Green); Console.Write("]");
            Console.Write(" Sim");
            Console.Write("  ["); Console.Write("2", Color.DarkRed); Console.Write("]");
            Console.Write(" Não\n");

            Console.Write("\n  C/: ");
            Pass = char.TryParse(Console.ReadLine(), out NumOp);

            if (Pass == true) {
                switch (NumOp)
                {
                    case '1':
                        Console.Clear();

                        Console.WriteLine("\n  Você realmente deseja sair ?\n", color: Color.Yellow);
                        Console.Write("  ["); Console.Write("1", Color.DarkRed); Console.Write("]");
                        Console.Write(" Sim");
                        Console.Write("  ["); Console.Write("2", Color.Green); Console.Write("]");
                        Console.Write(" Não\n");

                        Console.Write("\n  C/: ");
                        Pass = char.TryParse(Console.ReadLine(), out NumOp);

                        if (Pass)
                        {
                            switch (NumOp)
                            {
                                case '1':
                                    Console.Clear();
                                    Environment.Exit(0);
                                    break;

                                case '2':
                                    Program.Main();
                                    break;

                                default:
                                    Program.Mensagem = "Você selecionou uma opção que não existe !";
                                    Program.MensagemColor = Color.Red;
                                    Logo.SegundaCorDaLogo();
                                    Program.Main();
                                    break;
                            }
                        }
                        break;
                    case '2':
                        Program.Main();
                        break;

                    default:
                        Program.Mensagem = "Você selecionou uma opção que não existe !";
                        Program.MensagemColor = Color.Red;
                        Logo.SegundaCorDaLogo();
                        Program.Main();
                        break;
                }   
            }
        }
    }
}
