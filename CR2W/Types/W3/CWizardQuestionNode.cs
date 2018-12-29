using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]public class CWizardQuestionNode : CWizardBaseNode
    {
        [REDProp("uniqueName")]
        CName UniqueName { get; set; }

        [REDProp("layoutTemplate")]
        string LayoutTemplate { get; set; }

        [REDProp("text")]
        string Text { get; set; }

        [REDProp("optional")]
        bool Optional { get; set; }

        [REDProp("endNode")]
        bool EndNode { get; set; }
    }
}
