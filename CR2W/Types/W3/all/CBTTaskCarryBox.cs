using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCarryBox : IBehTreeTask
{
#region RED Properties

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("pickUpPoint")]
public CName PickUpPoint { get; set;}

[REDProp("dropPoint")]
public CName DropPoint { get; set;}

[REDProp("box")]
public Handle<CEntity> Box { get; set;}

#endregion
}
}