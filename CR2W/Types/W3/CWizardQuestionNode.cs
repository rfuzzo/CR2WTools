using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CWizardQuestionNode : CWizardBaseNode
    {
        [W3Type("uniqueName")]
        CName UniqueName { get; set; }

        [W3Type("layoutTemplate")]
        string LayoutTemplate { get; set; }

        [W3Type("text")]
        string Text { get; set; }

        [W3Type("optional")]
        bool Optional { get; set; }

        [W3Type("endNode")]
        bool EndNode { get; set; }
    }
}
