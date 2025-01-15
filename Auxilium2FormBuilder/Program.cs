using Auxilium2FormBuilder.Classes.FormDefinitionClasses;
using Auxilium2FormBuilder.Forms;

namespace Auxilium2FormBuilder
{
    internal static class Program
    {
        public static List<FormDefinition> FormDefinitions = new();


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}
