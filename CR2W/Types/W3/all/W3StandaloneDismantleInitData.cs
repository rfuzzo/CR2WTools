using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3StandaloneDismantleInitData : W3SingleMenuInitData
{
#region RED Properties

[REDProp("m_ingredientsForMissingDecoctions")]
public Array<CName> M_ingredientsForMissingDecoctions { get; set;}

#endregion
}
}