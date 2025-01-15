using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Classes.FormDefinitionClasses
{
    public class FormDefinition
    {
        public required Guid ID { get; set; }
        public required string TextPrefabPath { get; set; }
        public required FormPage[] Pages { get; set; }
        public required bool FinalReview { get; set; }
        public required FinalReview? Review { get; set; }
        public required OnSubmitOperation[] OnSubmitOperations { get; set; }

        public static FormDefinition FromJSON(Guid guid, JsonNode jsonNode)
        {
            string textPrefabPath = jsonNode["text_prefab_path"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'text_prefab_path' in JSON.");

            var pagesNode = jsonNode["pages"] as JsonArray ?? throw new InvalidOperationException("Missing or invalid 'pages' in JSON.");
            FormPage[] pages = pagesNode.Select(pageNode => FormPage.FromJSON(pageNode)).ToArray();


            bool finalReview = jsonNode["final_review"]?.GetValue<bool>() ?? throw new InvalidOperationException("Missing 'final_review' in JSON.");

            FinalReview? review = null;

            OnSubmitOperation[] onSubmitOperations = [];

            FormDefinition builder = new()
            {
                ID = guid,
                TextPrefabPath = textPrefabPath,
                Pages = pages,
                FinalReview = finalReview,
                Review = review,
                OnSubmitOperations = onSubmitOperations
            };

            return builder;
        }

        public JsonObject ToJSON()
        {
            var jsonObject = new JsonObject
            {
                ["text_prefab_path"] = TextPrefabPath,
                ["pages"] = new JsonArray(Pages.Select(page => page.ToJSON()).ToArray()),
                ["final_review"] = FinalReview
            };

            return jsonObject;
        }

        public void SaveToFile()
        {
            if (string.IsNullOrEmpty(Program.FormDefinitionDirectory))
                throw new ArgumentException("Directory path cannot be null or empty.", nameof(Program.FormDefinitionDirectory));

            string filePath = Path.Combine(Program.FormDefinitionDirectory, $"{ID}.json");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            string jsonString = ToJSON().ToJsonString(options);

            jsonString = jsonString.Replace("  ", "    ");

            File.WriteAllText(filePath, jsonString);
        }
    }
}
