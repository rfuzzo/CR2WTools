using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHairCutSceneChoiceAction : CStorySceneChoiceLineActionScripted
{
#region RED Properties

[REDProp("money")]
public Int32 Money { get; set;}

#endregion
}
}