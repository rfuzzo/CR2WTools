using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPayStorySceneChoiceAction : CStorySceneChoiceLineActionScripted
{
#region RED Properties

[REDProp("money")]
public Int32 Money { get; set;}

[REDProp("dontGrantExp")]
public bool DontGrantExp { get; set;}

[REDProp("actionIcon")]
public EDialogActionIcon ActionIcon { get; set;}

#endregion
}
}