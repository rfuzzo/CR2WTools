using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTTaskCarryBoxDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("entityTemplate")]
public CName EntityTemplate { get; set;}

[REDProp("pickUpPoint")]
public CBehTreeValCName PickUpPoint { get; set;}

[REDProp("dropPoint")]
public CBehTreeValCName DropPoint { get; set;}

#endregion
}
}