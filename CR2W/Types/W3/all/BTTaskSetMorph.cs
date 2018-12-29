using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSetMorph : IBehTreeTask
{
#region RED Properties

[REDProp("morphOnAnimEvent")]
public bool MorphOnAnimEvent { get; set;}

[REDProp("time")]
public float Time { get; set;}

[REDProp("ratio")]
public float Ratio { get; set;}

[REDProp("morphOnActivate")]
public bool MorphOnActivate { get; set;}

[REDProp("ratioOnActivate")]
public float RatioOnActivate { get; set;}

[REDProp("timeOnActivate")]
public float TimeOnActivate { get; set;}

[REDProp("morphOnDeactivate")]
public bool MorphOnDeactivate { get; set;}

[REDProp("ratioOnDeactivate")]
public float RatioOnDeactivate { get; set;}

[REDProp("timeOnDeactivate")]
public float TimeOnDeactivate { get; set;}

[REDProp("m_morphIsLaunched")]
public bool M_morphIsLaunched { get; set;}

#endregion
}
}