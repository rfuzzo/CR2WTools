using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3WitcherBed : W3AnimationInteractionEntity
{
#region RED Properties

[REDProp("m_wasUsed")]
public bool M_wasUsed { get; set;}

[REDProp("m_wereItemsRefilled")]
public bool M_wereItemsRefilled { get; set;}

[REDProp("m_bedSaveLock")]
public Int32 M_bedSaveLock { get; set;}

[REDProp("m_bedLevel")]
public Int32 M_bedLevel { get; set;}

[REDProp("m_handsIkActive")]
public bool M_handsIkActive { get; set;}

#endregion
}
}