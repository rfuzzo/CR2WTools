using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeAtomicSailorMoveToPathDefinition : CBehTreeNodeAtomicActionDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("boatTag")]
public CBehTreeValCName BoatTag { get; set;}

[REDProp("pathTag")]
public CBehTreeValCName PathTag { get; set;}

[REDProp("upThePath")]
public CBehTreeValBool UpThePath { get; set;}

[REDProp("startFromBeginning")]
public CBehTreeValBool StartFromBeginning { get; set;}

#endregion
}
}