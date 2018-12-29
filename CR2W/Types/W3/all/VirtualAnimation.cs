using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class VirtualAnimation 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("time")]
public float Time { get; set;}

[REDProp("startTime")]
public float StartTime { get; set;}

[REDProp("endTime")]
public float EndTime { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("useMotion")]
public bool UseMotion { get; set;}

[REDProp("boneToExtract")]
public int BoneToExtract { get; set;}

[REDProp("bones")]
public Array<Int32> Bones { get; set;}

[REDProp("weights")]
public Array<float> Weights { get; set;}

[REDProp("blendIn")]
public float BlendIn { get; set;}

[REDProp("blendOut")]
public float BlendOut { get; set;}

[REDProp("track")]
public int Track { get; set;}

[REDProp("animset")]
public Soft<CSkeletalAnimationSet> Animset { get; set;}

#endregion
}
}