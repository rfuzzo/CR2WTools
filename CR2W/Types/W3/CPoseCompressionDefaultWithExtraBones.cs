using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CPoseCompressionDefaultWithExtraBones : CPoseCompressionDefault
{
#region RED Properties

[REDProp("firstRotBoneName")]
public string FirstRotBoneName { get; set;}

[REDProp("lastRotBoneName")]
public string LastRotBoneName { get; set;}

[REDProp("firstTransBoneName")]
public string FirstTransBoneName { get; set;}

[REDProp("lastTransBoneName")]
public string LastTransBoneName { get; set;}

[REDProp("firstRotBone")]
public int FirstRotBone { get; set;}

[REDProp("lastRotBone")]
public int LastRotBone { get; set;}

[REDProp("firstTransBone")]
public int FirstTransBone { get; set;}

[REDProp("lastTransBone")]
public int LastTransBone { get; set;}

[REDProp("compressTranslationType")]
public ECompressTranslationType CompressTranslationType { get; set;}

[REDProp("extraRotBones")]
public Array<Int32> ExtraRotBones { get; set;}

[REDProp("extraTransBones")]
public Array<Int32> ExtraTransBones { get; set;}

#endregion
}
}