using Colorful;
using System.Drawing;
using Console = Colorful.Console;

namespace MySecondCRUD {
    internal class Logo {
        public static Color CrudLogoColor = Color.Magenta;
        public static Color ComLogoColor = Color.DarkMagenta;
        public static Color ExcelLogoColor = Color.Green;

        public static void Titulo() {
            Console.Write("\n   ▄████▄   ██▀███   █    ██ ▓█████▄ ", color: CrudLogoColor);
            Console.Write("     ▄████▄   ▒█████   ███▄ ▄███▓", color: ComLogoColor);
            Console.Write("   ▓█████ ▒██   ██▒ ▄████▄  ▓█████  ██▓\n", color: ExcelLogoColor);
            Console.Write("  ▒██▀ ▀█  ▓██ ▒ ██▒ ██  ▓██▒▒██▀ ██▌", color: CrudLogoColor);
            Console.Write("    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒", color: ComLogoColor);
            Console.Write("   ▓█   ▀ ▒▒ █ █ ▒░▒██▀ ▀█  ▓█   ▀ ▓██▒\n", color: ExcelLogoColor);
            Console.Write("  ▒▓█    ▄ ▓██ ░▄█ ▒▓██  ▒██░░██    █▌", color: CrudLogoColor);
            Console.Write("   ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░", color: ComLogoColor);
            Console.Write("   ▒███   ░░  █   ░▒▓█    ▄ ▒███   ▒██░\n", color: ExcelLogoColor);
            Console.Write("  ▒▓▓▄ ▄██▒▒██▀▀█▄  ▓▓█  ░██░░▓█▄   ▌", color: CrudLogoColor);
            Console.Write("    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██", color: ComLogoColor);
            Console.Write("    ▒▓█  ▄  ░ █ █ ▒ ▒▓▓▄ ▄██▒▒▓█  ▄ ▒██░\n", color: ExcelLogoColor);
            Console.Write("  ▒ ▓███▀ ░░██▓ ▒██▒▒▒█████▓ ░▒████▓", color: CrudLogoColor);
            Console.Write("     ▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒", color: ComLogoColor);
            Console.Write("   ░▒████▒▒██▒ ▒██▒▒ ▓███▀ ░░▒████▒░██████▒\n", color: ExcelLogoColor);
            Console.Write("  ░ ░▒ ▒  ░░ ▒▓ ░▒▓░░▒▓▒ ▒ ▒  ▒▒▓  ▒", color: CrudLogoColor);
            Console.Write("    ░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░", color: ComLogoColor);
            Console.Write("   ░░ ▒░ ░▒▒ ░ ░▓ ░░ ░▒ ▒  ░░░ ▒░ ░░ ▒░▓  ░\n", color: ExcelLogoColor);
            Console.Write("    ░  ▒     ░▒ ░ ▒░░░▒░ ░ ░  ░ ▒  ▒   ", color: CrudLogoColor);
            Console.Write("    ░  ▒     ░ ▒ ▒░ ░  ░      ░", color: ComLogoColor);
            Console.Write("     ░ ░  ░░░   ░▒ ░  ░  ▒    ░ ░  ░░ ░ ▒  ░\n", color: ExcelLogoColor);
            Console.Write("  ░          ░░   ░  ░░░ ░ ░  ░ ░  ░", color: CrudLogoColor);
            Console.Write("    ░        ░ ░ ░ ▒  ░      ░", color: ComLogoColor);
            Console.Write("         ░    ░    ░  ░           ░     ░ ░\n", color: ExcelLogoColor);
            Console.Write("  ░ ░         ░        ░        ░", color: CrudLogoColor);
            Console.Write("       ░ ░          ░ ░         ░", color: ComLogoColor);
            Console.Write("         ░  ░ ░    ░  ░ ░         ░  ░    ░  ░\n", color: ExcelLogoColor);
            Console.Write("  ░                           ░         ", color: CrudLogoColor);
            Console.Write("░                ", color: ComLogoColor);
            Console.Write("                 ░", color: ExcelLogoColor);
        }
        public static void ResetarCorDaLogo() {
            Console.ReplaceAllColorsWithDefaults();
            CrudLogoColor = Color.Magenta;
            ComLogoColor = Color.DarkMagenta;
            ExcelLogoColor = Color.Green;
        }
        public static void SegundaCorDaLogo() {
            Console.ReplaceAllColorsWithDefaults();
            CrudLogoColor = Color.Orange;
            ComLogoColor = Color.DarkOrange;
            ExcelLogoColor = Color.Yellow;
        }
    }
}
