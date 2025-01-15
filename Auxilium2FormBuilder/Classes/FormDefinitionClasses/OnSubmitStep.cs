using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Classes.FormDefinitionClasses
{
    public class OnSubmitStep
    {
        public required string Type { get; set; }


        public required string? Evaluation { get; set; }
        public required string? Schema { get; set; }
        public required string? Content { get; set; }
        public required string? MIMEType{ get; set; }
        public required string? Name { get; set; }
        public required string? Property { get; set; }
        public required string? Target { get; set; }
        public required string? OutputVariable { get; set; }
        public required string? Value { get; set; }
        public required bool? ReplaceLastReturnURL { get; set; }
        public required string? IfStatement { get; set; }


        public static OnSubmitStep FromJSON(JsonNode jsonNode)
        {
            string type = jsonNode["type"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'type' in JSON.");


            string? eval = jsonNode["eval"]?.GetValue<string>() ?? null;
            string? schema = jsonNode["schema"]?.GetValue<string>() ?? null;
            string? content = jsonNode["content"]?.GetValue<string>() ?? null;
            string? mimeType = jsonNode["mime_type"]?.GetValue<string>() ?? null;
            string? name = jsonNode["name"]?.GetValue<string>() ?? null;
            string? property = jsonNode["property"]?.GetValue<string>() ?? null;
            string? target = jsonNode["target"]?.GetValue<string>() ?? null;
            string? output_variable = jsonNode["output_variable"]?.GetValue<string>() ?? null;
            string? value = jsonNode["value"]?.GetValue<string>() ?? null;
            bool? replaceLastReturnURL = jsonNode["replace_last_return_url"]?.GetValue<bool>() ?? null;
            string? ifStatement = jsonNode["if"]?.GetValue<string>() ?? null;

            OnSubmitStep builder = new()
            {
                Type = type,

                Evaluation = eval,
                Schema = schema,
                Content = content,
                MIMEType = mimeType,
                Name = name,
                Property = property,
                Target = target,
                OutputVariable = output_variable,
                Value = value,
                ReplaceLastReturnURL = replaceLastReturnURL,
                IfStatement = ifStatement,
            };

            return builder;
        }

        public JsonObject ToJSON()
        {
            var jsonObject = new JsonObject
            {
                ["type"] = this.Type
            };

            if (this.IfStatement != null) jsonObject["if"] = this.IfStatement;

            if (this.Evaluation != null) jsonObject["eval"] = this.Evaluation;
            if (this.Content != null) jsonObject["content"] = this.Content;
            if (this.MIMEType != null) jsonObject["mime_type"] = this.MIMEType;
            if (this.Schema != null) jsonObject["schema"] = this.Schema;
            if (this.OutputVariable != null) jsonObject["output_variable"] = this.OutputVariable;
            if (this.Name != null) jsonObject["name"] = this.Name;
            if (this.Target != null) jsonObject["target"] = this.Target;
            if (this.Property != null) jsonObject["property"] = this.Property;
            if (this.ReplaceLastReturnURL != null) jsonObject["replace_last_return_url"] = this.ReplaceLastReturnURL;
            if (this.Value != null) jsonObject["value"] = this.Value;

            return jsonObject;
        }
    }
}
