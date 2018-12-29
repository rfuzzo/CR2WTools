using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CWizardDefinition : CResource
{
#region RED Properties

[REDProp("nodes")]
public Array<Ptr<CWizardQuestionNode>> Nodes { get; set;}

#endregion
}
}