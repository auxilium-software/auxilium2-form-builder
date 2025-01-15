using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Classes.FormDefinitionClasses
{
    public class FormPage
    {
        public required string? ID { get; set; }
        public required string Title { get; set; }
        public required string? Description { get; set; }
        public required string? If { get; set; }
        public required List<FormPageComponent> Components { get; set; }


        public static FormPage FromJSON(JsonNode jsonNode)
        {
            string id = jsonNode["id"]?.GetValue<string>() ?? null;

            string title = jsonNode["title"]?.GetValue<string>() ?? throw new InvalidOperationException("Missing 'title' in JSON.");

            string description = jsonNode["description"]?.GetValue<string>() ?? null;

            string ifStatement = jsonNode["if"]?.GetValue<string>() ?? null;

            var componentsNode = jsonNode["components"] as JsonArray ?? throw new InvalidOperationException("Missing or invalid 'components' in JSON.");
            List<FormPageComponent> components = componentsNode.Select(componentNode => FormPageComponent.FromJSON(componentNode)).ToList();

            FormPage builder = new()
            {
                ID = id,
                Title = title,
                Description = description,
                If = ifStatement,
                Components = components
            };



            return builder;
        }
    }
}
