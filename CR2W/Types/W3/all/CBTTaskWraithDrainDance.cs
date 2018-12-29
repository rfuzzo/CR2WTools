using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWraithDrainDance : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("drainDistance")]
public float DrainDistance { get; set;}

[REDProp("drainTemplate")]
public Handle<CEntityTemplate> DrainTemplate { get; set;}

[REDProp("m_isDraining")]
public bool M_isDraining { get; set;}

[REDProp("m_DrainEffectEntity")]
public Handle<CEntity> M_DrainEffectEntity { get; set;}

[REDProp("m_Disappeared")]
public bool M_Disappeared { get; set;}

#endregion
}
}