using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Classes.FormDefinitionClasses
{
    public class FinalReviewComponent
    {
        public required string Type { get; set; }


        public required string? Value { get; set; }
        public required string? JumpToPage { get; set; }
        public required string? IfStatement { get; set; }

        public required List<Tuple<string, string>>? Dictionary { get; set; }

        public static FinalReviewComponent FromJSON(JsonNode jsonNode)
        {
            string type = jsonNode["type"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'type' in JSON.");

            string? value = jsonNode["value"]?.GetValue<string>() ?? null;
            string? jumpToPage = jsonNode["jump_to_page"]?.GetValue<string>() ?? null;
            string? ifStatement = jsonNode["if"]?.GetValue<string>() ?? null;
            List<Tuple<string, string>>? dictionary = jsonNode["dictionary"] is JsonObject dictionaryNode
                ? dictionaryNode
                    .Select(kvp => new Tuple<string, string>(kvp.Key, kvp.Value!.GetValue<string>()))
                    .ToList()
                : null;

            FinalReviewComponent builder = new()
            {
                Type = type,

                Value = value,
                JumpToPage = jumpToPage,
                IfStatement = ifStatement,
                Dictionary = dictionary,
            };

            return builder;
        }

        public JsonObject ToJSON()
        {
            var jsonObject = new JsonObject
            {
                ["type"] = this.Type
            };

            if (this.Value != null) jsonObject["value"] = this.Value;
            if (this.JumpToPage != null) jsonObject["jump_to_page"] = this.JumpToPage;
            if (this.IfStatement != null) jsonObject["if"] = this.IfStatement;
            if (this.Dictionary != null)
            {
                var dictionaryNode = new JsonObject();
                foreach (var (key, value) in this.Dictionary)
                {
                    dictionaryNode[key] = value;
                }
                jsonObject["dictionary"] = dictionaryNode;
            }

            return jsonObject;
        }
    }
}
