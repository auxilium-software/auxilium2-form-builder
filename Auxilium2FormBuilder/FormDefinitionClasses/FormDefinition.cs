using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.FormDefinitionClasses
{
    public class FormDefinition
    {
        public required Guid ID { get; set; }
        public required string TextPrefabPath { get; set; }
        public required FormPage[] Pages { get; set; }
        public required bool ShouldFinalReview { get; set; }
        public required FinalReview? Review { get; set; }
        public required List<OnSubmitStep> OnSubmitOperations { get; set; }

        public static FormDefinition FromJSON(Guid guid, JsonNode jsonNode)
        {
            string textPrefabPath = jsonNode["text_prefab_path"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'text_prefab_path' in JSON.");

            var pagesNode = jsonNode["pages"] as JsonArray ?? throw new InvalidOperationException("Missing or invalid 'pages' in JSON.");
            FormPage[] pages = pagesNode.Select(pageNode => FormPage.FromJSON(pageNode)).ToArray();


            bool finalReview = jsonNode["final_review"]?.GetValue<bool>() ?? throw new InvalidOperationException("Missing 'final_review' in JSON.");

            var onReviewNode = jsonNode["review"] as JsonObject ?? null;
            FinalReview? review = null;
            if (onReviewNode != null)
                review = FinalReview.FromJSON(onReviewNode);

            var onSubmitNode = jsonNode["on_submit"] as JsonArray ?? throw new InvalidOperationException("Missing or invalid 'on_submit' in JSON.");
            List<OnSubmitStep> onSubmitOperations = onSubmitNode.Select(onSubmitNode => OnSubmitStep.FromJSON(onSubmitNode)).ToList();

            FormDefinition builder = new()
            {
                ID = guid,
                TextPrefabPath = textPrefabPath,
                Pages = pages,
                ShouldFinalReview = finalReview,
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
                ["final_review"] = ShouldFinalReview
            };

            if (Review != null)
                jsonObject["review"] = Review.ToJSON();

            jsonObject["on_submit"] = new JsonArray(OnSubmitOperations.Select(op => op.ToJSON()).ToArray());

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
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };

            string jsonString = ToJSON().ToJsonString(options);

            jsonString = jsonString.Replace("  ", "    ");
            jsonString = jsonString + "\n";

            File.WriteAllText(filePath, jsonString);
        }
    }
}
