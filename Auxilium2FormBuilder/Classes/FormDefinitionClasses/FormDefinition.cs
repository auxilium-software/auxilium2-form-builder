using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Classes.FormDefinitionClasses
{
    public class FormDefinition
    {
        public required string TextPrefabPath { get; set; }
        public required FormPage[] Pages { get; set; }
        public required bool FinalReview { get; set; }
        public required FinalReview? Review { get; set; }
        public required OnSubmitOperation[] OnSubmitOperations { get; set; }

        public static FormDefinition FromJSON(JsonNode jsonNode)
        {
            string textPrefabPath = jsonNode["text_prefab_path"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'text_prefab_path' in JSON.");

            var pagesNode = jsonNode["pages"] as JsonArray ?? throw new InvalidOperationException("Missing or invalid 'pages' in JSON.");
            FormPage[] pages = pagesNode.Select(pageNode => FormPage.FromJSON(pageNode)).ToArray();


            bool finalReview = jsonNode["final_review"]?.GetValue<bool>() ?? throw new InvalidOperationException("Missing 'final_review' in JSON.");

            FinalReview? review = null;

            OnSubmitOperation[] onSubmitOperations = [];

            FormDefinition builder = new()
            {
                TextPrefabPath = textPrefabPath,
                Pages = pages,
                FinalReview = finalReview,
                Review = review,
                OnSubmitOperations = onSubmitOperations
            };

            return builder;
        }
    }
}
