using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFXTrackItemFlare : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("material")]
public Handle<CMaterialInstance> Material { get; set;}

[REDProp("parameters")]
public SFlareParameters Parameters { get; set;}

[REDProp("spawner")]
public Ptr<IFXSpawner> Spawner { get; set;}

#endregion
}
}