using Auxilium2FormBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Classes.FormDefinitionClasses
{
    public enum FormPageComponentType : Int16
    {
        [StringValue("TEXT_FIELD")]
        TEXT_FIELD = 10,
        [StringValue("LARGE_TEXT_FIELD")]
        LARGE_TEXT_FIELD = 11,

        [StringValue("CHOICE_FIELD")]
        RADIO_BUTTON = 20
    }
}
