using RED.Reflection;
using System;

namespace RED.Core
{
    public class CWizardQuestionNode : CWizardBaseNode
    {
        #region Protected RED Props
        [RED] protected CName uniqueName;
        [RED] protected String layoutTemplate;
        [RED] protected String text;
        [RED] protected Boolean optional;
        [RED] protected Boolean endNode;
        #endregion

        #region Public Props
        public CName UniqueName
        {
            get => uniqueName;
            set => uniqueName = value;
        }
        public String LayoutTemplate
        {
            get => layoutTemplate;
            set => layoutTemplate = value;
        }
        public String Text
        {
            get => text;
            set => text = value;
        }
        public Boolean Optional
        {
            get => optional;
            set => optional = value;
        }
        public Boolean EndNode
        {
            get => endNode;
            set => endNode = value;
        }
        #endregion
    }
}
