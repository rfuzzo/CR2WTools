using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSoundInfoMapping 
{
#region RED Properties

[REDProp("soundTypeIdentification")]
public CName SoundTypeIdentification { get; set;}

[REDProp("soundSizeIdentification")]
public CName SoundSizeIdentification { get; set;}

[REDProp("boneIndexes")]
public Array<Int32> BoneIndexes { get; set;}

[REDProp("isDefault")]
public bool IsDefault { get; set;}

#endregion
}
}