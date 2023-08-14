using DesafioCRUD.View;

namespace DesafioCRUD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Cadastro());
        }
    }
}