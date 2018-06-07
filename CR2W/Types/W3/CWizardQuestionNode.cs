using System;

namespace CR2W.Types.W3
{
    public class CWizardQuestionNode : CWizardBaseNode
    {
        CName UniqueName { get; set; }
        string LayoutTemplate { get; set; }
        string Text { get; set; }
        bool Optional { get; set; }
        bool EndNode { get; set; }
    }
}
