using Auxilium2FormBuilder.FormDefinitionClasses;
using Auxilium2FormBuilder.Forms;
using System.Text.Json.Nodes;

namespace Auxilium2FormBuilder
{
    internal static class Program
    {
        public static string SchemaURL = "https://schemas.darksparrow.uk/AuxiliumFormDefinition.json?version=4";

        public static string FormDefinitionDirectory;
        public static string LocalisedStringsFilePath;

        public static List<FormDefinition> FormDefinitions = [];
        public static JsonNode LocalisedStrings;
        public static List<string> AvailableLanguages = [];

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


            string fileContents2 = File.ReadAllText(Program.LocalisedStringsFilePath);
            Program.LocalisedStrings = JsonObject.Parse(fileContents2);
            var languages = new HashSet<string>();
            ExtractLanguages(Program.LocalisedStrings, languages);
            Program.AvailableLanguages = languages.ToList().Distinct().ToList();
        }
        public static void ExtractLanguages(JsonNode node, HashSet<string> languages)
        {
            if (node is JsonObject obj)
            {
                foreach (var property in obj)
                {
                    // If the value is another JsonObject or JsonArray, recurse
                    if (property.Value is JsonObject || property.Value is JsonArray)
                    {
                        ExtractLanguages(property.Value, languages);
                    }

                    // If the property name is a language code (like "en" or "cy"), add to the set
                    else if (property.Key.Length == 2)
                    {
                        languages.Add(property.Key);
                    }
                }
            }
            else if (node is JsonArray array)
            {
                foreach (var item in array)
                {
                    ExtractLanguages(item, languages);
                }
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

            foreach (FormDefinition formDef in Program.FormDefinitions)
            {
                formDef.DeleteFile(true);
            }
        }
    }
}
