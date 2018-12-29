using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDefend : IBehTreeTask
{
#region RED Properties

[REDProp("useCustomHits")]
public bool UseCustomHits { get; set;}

[REDProp("listenToParryEvents")]
public bool ListenToParryEvents { get; set;}

[REDProp("completeTaskOnIsDefending")]
public bool CompleteTaskOnIsDefending { get; set;}

[REDProp("minimumDuration")]
public float MinimumDuration { get; set;}

[REDProp("playParrySound")]
public bool PlayParrySound { get; set;}

[REDProp("m_activationTime")]
public float M_activationTime { get; set;}

#endregion
}
}