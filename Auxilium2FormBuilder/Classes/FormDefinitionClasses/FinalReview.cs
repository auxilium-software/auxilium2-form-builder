using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Classes.FormDefinitionClasses
{
    public class FinalReview
    {
        public required List<FinalReviewComponent> Components { get; set; }

        public static FinalReview FromJSON(JsonNode jsonNode)
        {
            var componentsNode = jsonNode["components"] as JsonArray ?? null;
            List<FinalReviewComponent>? reviewSteps = null;
            if (componentsNode != null)
                reviewSteps = componentsNode.Select(onReviewNode => FinalReviewComponent.FromJSON(onReviewNode)).ToList();

            FinalReview builder = new()
            {
                Components = reviewSteps
            };

            return builder;
        }

        public JsonObject ToJSON()
        {
            var jsonObject = new JsonObject
            {
                ["components"] = new JsonArray(Components.Select(component => component.ToJSON()).ToArray()),
            };

            return jsonObject;
        }
    }
}
