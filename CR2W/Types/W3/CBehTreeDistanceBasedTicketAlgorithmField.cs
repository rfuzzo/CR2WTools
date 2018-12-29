using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeDistanceBasedTicketAlgorithmField 
{
#region RED Properties

[REDProp("distance")]
public CBehTreeValFloat Distance { get; set;}

[REDProp("importance")]
public float Importance { get; set;}

#endregion
}
}