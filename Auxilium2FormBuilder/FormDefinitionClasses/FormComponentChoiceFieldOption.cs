using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.FormDefinitionClasses
{
    public class FormComponentChoiceFieldOption
    {
        public required string LabelStrong { get; set; }
        public required string? LabelSecondary { get; set; }
        public required string Value { get; set; }

        public static FormComponentChoiceFieldOption FromJSON(JsonNode jsonNode)
        {
            string labelStrong = jsonNode["label_strong"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'label_strong' in JSON.");

            string labelSecondary = jsonNode["label_secondary"]?.GetValue<string>() ?? null;

            string value = jsonNode["value"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'value' in JSON.");

            FormComponentChoiceFieldOption builder = new()
            {
                LabelStrong = labelStrong,
                LabelSecondary = labelSecondary,
                Value = value
            };

            return builder;
        }
        public JsonObject ToJSON()
        {
            var jsonObject = new JsonObject
            {
                ["label_strong"] = LabelStrong,
            };

            if (LabelSecondary != null) jsonObject["label_secondary"] = LabelSecondary;
            if (Value != null) jsonObject["value"] = Value;
            return jsonObject;
        }
    }
}
