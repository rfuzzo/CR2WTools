using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSailorMountBoatDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("boatTag")]
public CBehTreeValCName BoatTag { get; set;}

[REDProp("instantMount")]
public CBehTreeValBool InstantMount { get; set;}

#endregion
}
}