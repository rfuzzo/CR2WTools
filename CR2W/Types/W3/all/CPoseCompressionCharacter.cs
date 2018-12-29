using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPoseCompressionCharacter : CPoseCompressionDefault
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

[REDProp("leftWeaponName")]
public string LeftWeaponName { get; set;}

[REDProp("rightWeaponName")]
public string RightWeaponName { get; set;}

[REDProp("leftWeapon")]
public int LeftWeapon { get; set;}

[REDProp("rightWeapon")]
public int RightWeapon { get; set;}

#endregion
}
}