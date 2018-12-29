using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcBoxCarryParams : CAINpcIdleParams
{
#region RED Properties

[REDProp("workCarryItemTemplate")]
public Handle<CEntityTemplate> WorkCarryItemTemplate { get; set;}

[REDProp("workCarryPickupPoint")]
public CName WorkCarryPickupPoint { get; set;}

[REDProp("workCarryDropPoint")]
public CName WorkCarryDropPoint { get; set;}

#endregion
}
}