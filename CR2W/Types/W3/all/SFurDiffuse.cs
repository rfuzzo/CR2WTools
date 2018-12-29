using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SFurDiffuse 
{
#region RED Properties

[REDProp("diffuseBlend")]
public float DiffuseBlend { get; set;}

[REDProp("diffuseScale")]
public float DiffuseScale { get; set;}

[REDProp("diffuseHairNormalWeight")]
public float DiffuseHairNormalWeight { get; set;}

[REDProp("diffuseBoneIndex")]
public uint DiffuseBoneIndex { get; set;}

[REDProp("diffuseBoneLocalPos")]
public Vector DiffuseBoneLocalPos { get; set;}

[REDProp("diffuseNoiseScale")]
public float DiffuseNoiseScale { get; set;}

[REDProp("diffuseNoiseFreqU")]
public float DiffuseNoiseFreqU { get; set;}

[REDProp("diffuseNoiseFreqV")]
public float DiffuseNoiseFreqV { get; set;}

[REDProp("diffuseNoiseGain")]
public float DiffuseNoiseGain { get; set;}

#endregion
}
}