using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CWizardDefinition : CResource
    {
        [W3Type("nodes")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CWizardQuestionNode>> Nodes { get; set; }
    }
}