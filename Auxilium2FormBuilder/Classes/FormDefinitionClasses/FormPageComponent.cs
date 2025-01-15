using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Classes.FormDefinitionClasses
{
    public class FormPageComponent
    {
        public required string Type { get; set; }
        public required FormComponentChoiceFieldOption[]? Options { get; set; }
        public required string? Label { get; set; }
        public required string? DefaultValue { get; set; }
        public required string OutputVariable { get; set; }
        public required bool Required { get; set; }

        public static FormPageComponent FromJSON(JsonNode jsonNode)
        {
            string type = jsonNode["type"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'type' in JSON.");

            var optionsNode = jsonNode["options"] as JsonArray ?? null;
            FormComponentChoiceFieldOption[]? options = null;
            if (optionsNode != null)
                options = optionsNode.Select(pageNode => FormComponentChoiceFieldOption.FromJSON(pageNode)).ToArray();

            string label = jsonNode["label"]?.GetValue<string>() ?? null;

            string defaultValue = jsonNode["default_value"]?.GetValue<string>() ?? null;

            string outputVariable = jsonNode["output_variable"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'output_variable' in JSON.");

            bool required = jsonNode["required"]?.GetValue<bool>() ?? throw new InvalidOperationException("Missing 'required' in JSON.");

            FormPageComponent builder = new()
            {
                Type = type,
                Options = options,
                Label = label,
                DefaultValue = defaultValue,
                OutputVariable = outputVariable,
                Required = required
            };

            return builder;
        }
    }
}
