using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CWizardQuestionNode : CWizardBaseNode
{
#region RED Properties

[REDProp("uniqueName")]
public CName UniqueName { get; set;}

[REDProp("layoutTemplate")]
public string LayoutTemplate { get; set;}

[REDProp("text")]
public string Text { get; set;}

[REDProp("optional")]
public bool Optional { get; set;}

[REDProp("endNode")]
public bool EndNode { get; set;}

#endregion
}
}