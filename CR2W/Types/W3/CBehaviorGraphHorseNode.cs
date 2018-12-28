using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphHorseNode : CBehaviorGraphBaseNode
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("activateNotification")]
public CName ActivateNotification { get; set;}

[REDProp("deactivateNotification")]
public CName DeactivateNotification { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("cachedSpeedValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedSpeedValueNode { get; set;}

[REDProp("speedStep")]
public float SpeedStep { get; set;}

[REDProp("slopeFBVar")]
public CName SlopeFBVar { get; set;}

[REDProp("slopeLRVar")]
public CName SlopeLRVar { get; set;}

[REDProp("firstBoneF")]
public string FirstBoneF { get; set;}

[REDProp("secondBoneF")]
public string SecondBoneF { get; set;}

[REDProp("thirdBoneF")]
public string ThirdBoneF { get; set;}

[REDProp("endBoneF")]
public string EndBoneF { get; set;}

[REDProp("hingeAxisF")]
public EAxis HingeAxisF { get; set;}

[REDProp("firstBoneB")]
public string FirstBoneB { get; set;}

[REDProp("secondBoneB")]
public string SecondBoneB { get; set;}

[REDProp("thirdBoneB")]
public string ThirdBoneB { get; set;}

[REDProp("endBoneB")]
public string EndBoneB { get; set;}

[REDProp("hingeAxisB")]
public EAxis HingeAxisB { get; set;}

[REDProp("root")]
public string Root { get; set;}

[REDProp("pelvis")]
public string Pelvis { get; set;}

[REDProp("axisRootFB")]
public EAxis AxisRootFB { get; set;}

[REDProp("axisRootLR")]
public EAxis AxisRootLR { get; set;}

[REDProp("headFirst")]
public string HeadFirst { get; set;}

[REDProp("headSecond")]
public string HeadSecond { get; set;}

[REDProp("headThird")]
public string HeadThird { get; set;}

[REDProp("hingeAxisHead")]
public EAxis HingeAxisHead { get; set;}

[REDProp("walkFBP")]
public SHorseStateOffsets WalkFBP { get; set;}

[REDProp("trotFBP")]
public SHorseStateOffsets TrotFBP { get; set;}

[REDProp("gallopFBP")]
public SHorseStateOffsets GallopFBP { get; set;}

[REDProp("canterFBP")]
public SHorseStateOffsets CanterFBP { get; set;}

[REDProp("walkFBN")]
public SHorseStateOffsets WalkFBN { get; set;}

[REDProp("trotFBN")]
public SHorseStateOffsets TrotFBN { get; set;}

[REDProp("gallopFBN")]
public SHorseStateOffsets GallopFBN { get; set;}

[REDProp("canterFBN")]
public SHorseStateOffsets CanterFBN { get; set;}

[REDProp("walkLR")]
public SHorseStateOffsets WalkLR { get; set;}

[REDProp("trotLR")]
public SHorseStateOffsets TrotLR { get; set;}

[REDProp("gallopLR")]
public SHorseStateOffsets GallopLR { get; set;}

[REDProp("canterLR")]
public SHorseStateOffsets CanterLR { get; set;}

#endregion
}
}