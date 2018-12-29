using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ReplacerWarningArea : CEntity
{
#region RED Properties

[REDProp("messageKey")]
public string MessageKey { get; set;}

[REDProp("messageInterval")]
public float MessageInterval { get; set;}

[REDProp("invertLogic")]
public bool InvertLogic { get; set;}

[REDProp("isPlayerInArea")]
public bool IsPlayerInArea { get; set;}

#endregion
}
}