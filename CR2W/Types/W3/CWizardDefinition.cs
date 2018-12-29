using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]public class CWizardDefinition : CResource
    {
        [REDProp("nodes", 2, 0)]
        public Array<Ptr<CWizardQuestionNode>> Nodes { get; set; }
    }
}