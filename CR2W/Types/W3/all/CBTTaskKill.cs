using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskKill : IBehTreeTask
{
#region RED Properties

[REDProp("actor")]
public Handle<CActor> Actor { get; set;}

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("fact")]
public string Fact { get; set;}

[REDProp("value")]
public Int32 Value { get; set;}

[REDProp("validFor")]
public Int32 ValidFor { get; set;}

[REDProp("signalGameplayEvent")]
public CName SignalGameplayEvent { get; set;}

[REDProp("playEffectOnKill")]
public CName PlayEffectOnKill { get; set;}

[REDProp("self")]
public bool Self { get; set;}

[REDProp("target")]
public bool Target { get; set;}

[REDProp("player")]
public bool Player { get; set;}

[REDProp("onlyBelowHealthPercent")]
public float OnlyBelowHealthPercent { get; set;}

[REDProp("onDamageTaken")]
public bool OnDamageTaken { get; set;}

[REDProp("onAardHit")]
public bool OnAardHit { get; set;}

[REDProp("onIgniHit")]
public bool OnIgniHit { get; set;}

[REDProp("onAxiiHit")]
public bool OnAxiiHit { get; set;}

[REDProp("onHeadshot")]
public bool OnHeadshot { get; set;}

[REDProp("onCustomHit")]
public bool OnCustomHit { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onListenToGameplayEvents")]
public bool OnListenToGameplayEvents { get; set;}

[REDProp("setBehVarOnKill")]
public CName SetBehVarOnKill { get; set;}

[REDProp("behVarValue")]
public float BehVarValue { get; set;}

#endregion
}
}