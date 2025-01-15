using Auxilium2FormBuilder.Enumerators;
using Auxilium2FormBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Auxilium2FormBuilder.FormDefinitionClasses
{
    public class FormPageComponent
    {
        public required FormPageComponentType Type { get; set; }


        public required int? Rows { get; set; }
        public required FormComponentChoiceFieldOption[]? Options { get; set; }


        public required string? Label { get; set; }
        public required string? DefaultValue { get; set; }
        public required string OutputVariable { get; set; }
        public required bool Required { get; set; }

        public static FormPageComponent FromJSON(JsonNode jsonNode)
        {
            string typeTemp = jsonNode["type"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'type' in JSON.");
            FormPageComponentType type = Enum.Parse<FormPageComponentType>(typeTemp);



            int? rows = jsonNode["rows"]?.GetValue<int>() ?? null;

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

                Rows = rows,
                Options = options,

                Label = label,
                DefaultValue = defaultValue,
                OutputVariable = outputVariable,
                Required = required
            };

            return builder;
        }

        public JsonObject ToJSON()
        {
            var jsonObject = new JsonObject
            {
                ["type"] = Type.StringValue()
            };

            if (Rows != null) jsonObject["rows"] = Rows;
            if (Options != null) jsonObject["options"] = new JsonArray(Options.Select(option => option.ToJSON()).ToArray());

            if (Label != null) jsonObject["label"] = Label;
            if (DefaultValue != null) jsonObject["default_value"] = DefaultValue;
            jsonObject["output_variable"] = OutputVariable;
            jsonObject["required"] = Required;
            return jsonObject;
        }
    }
}
