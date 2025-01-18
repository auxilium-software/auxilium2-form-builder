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
                formDef.SaveToFile(false);
            }
        }

        public static void UpdateFormDefTempFiles()
        {
            foreach (FormDefinition formDef in Program.FormDefinitions)
            {
                formDef.SaveToFile(false);
            }
        }


        public static void UpdateFromFiles()
        {
            Program.FormDefinitions.Clear();
            string[] files = Directory.GetFiles(path: Program.FormDefinitionDirectory, searchPattern: "*.json", searchOption: SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string fileContents = File.ReadAllText(file);
                var jsonContents = JsonObject.Parse(fileContents);

                Guid guid = Guid.Parse(file.Replace(oldValue: Program.FormDefinitionDirectory + "\\", newValue: "").Replace(oldValue: ".json", newValue: ""));

                FormDefinition formDefinition = FormDefinition.FromJSON(guid: guid, jsonNode: jsonContents);

                Program.FormDefinitions.Add(formDefinition);
            }
            Program.UpdateFormDefTempFiles();
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

            foreach (FormDefinition formDef in Program.FormDefinitions)
            {
                formDef.DeleteFile(true);
            }
        }
    }
}
