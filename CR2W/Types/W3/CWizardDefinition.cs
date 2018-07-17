using System;


namespace CR2W.Types.W3
{
    public class CWizardDefinition : CResource
    {
        [REDProp("nodes", 2, 0)]
        public Array<Ptr<CWizardQuestionNode>> Nodes { get; set; }
    }
}