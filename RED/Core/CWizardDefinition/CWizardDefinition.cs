using RED.Reflection;

namespace RED.Core
{
    public class CWizardDefinition : CResource
    {
        [RED(2, 0)]
        private protected TDynArray<Pointer<CWizardQuestionNode>> nodes;

        public TDynArray<Pointer<CWizardQuestionNode>> Nodes
        {
            get => nodes;
            set => nodes = value;
        }
    }
}