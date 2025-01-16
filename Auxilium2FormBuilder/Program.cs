using Auxilium2FormBuilder.FormDefinitionClasses;
using Auxilium2FormBuilder.Forms;
using System.Text.Json.Nodes;

namespace Auxilium2FormBuilder
{
    internal static class Program
    {
        public static string SchemaURL = "https://schemas.darksparrow.uk/AuxiliumFormDefinition.json?version=4";

        public static string FormDefinitionDirectory;
        public static List<FormDefinition> FormDefinitions = new();

        public static void UpdateFormDefFiles()
        {
            foreach(FormDefinition formDef in Program.FormDefinitions)
            {
                formDef.SaveToFile();
            }
        }



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
