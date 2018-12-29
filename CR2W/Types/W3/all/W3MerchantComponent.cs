using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MerchantComponent : CScriptedComponent
{
#region RED Properties

[REDProp("mapPinType")]
public EMerchantMapPinType MapPinType { get; set;}

#endregion
}
}