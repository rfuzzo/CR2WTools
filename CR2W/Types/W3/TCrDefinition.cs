using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class TCrDefinition : CObject
{
#region RED Properties

[REDProp("root")]
public CName Root { get; set;}

[REDProp("indexRoot")]
public int IndexRoot { get; set;}

[REDProp("pelvis")]
public CName Pelvis { get; set;}

[REDProp("indexPelvis")]
public int IndexPelvis { get; set;}

[REDProp("torso1")]
public CName Torso1 { get; set;}

[REDProp("indexTorso1")]
public int IndexTorso1 { get; set;}

[REDProp("torso2")]
public CName Torso2 { get; set;}

[REDProp("indexTorso2")]
public int IndexTorso2 { get; set;}

[REDProp("torso3")]
public CName Torso3 { get; set;}

[REDProp("indexTorso3")]
public int IndexTorso3 { get; set;}

[REDProp("neck")]
public CName Neck { get; set;}

[REDProp("indexNeck")]
public int IndexNeck { get; set;}

[REDProp("head")]
public CName Head { get; set;}

[REDProp("indexHead")]
public int IndexHead { get; set;}

[REDProp("shoulderL")]
public CName ShoulderL { get; set;}

[REDProp("indexShoulderL")]
public int IndexShoulderL { get; set;}

[REDProp("bicepL")]
public CName BicepL { get; set;}

[REDProp("indexBicepL")]
public int IndexBicepL { get; set;}

[REDProp("forearmL")]
public CName ForearmL { get; set;}

[REDProp("indexForearmL")]
public int IndexForearmL { get; set;}

[REDProp("handL")]
public CName HandL { get; set;}

[REDProp("indexHandL")]
public int IndexHandL { get; set;}

[REDProp("weaponL")]
public CName WeaponL { get; set;}

[REDProp("indexWeaponL")]
public int IndexWeaponL { get; set;}

[REDProp("shoulderR")]
public CName ShoulderR { get; set;}

[REDProp("indexShoulderR")]
public int IndexShoulderR { get; set;}

[REDProp("bicepR")]
public CName BicepR { get; set;}

[REDProp("indexBicepR")]
public int IndexBicepR { get; set;}

[REDProp("forearmR")]
public CName ForearmR { get; set;}

[REDProp("indexForearmR")]
public int IndexForearmR { get; set;}

[REDProp("handR")]
public CName HandR { get; set;}

[REDProp("indexHandR")]
public int IndexHandR { get; set;}

[REDProp("weaponR")]
public CName WeaponR { get; set;}

[REDProp("indexWeaponR")]
public int IndexWeaponR { get; set;}

[REDProp("thighL")]
public CName ThighL { get; set;}

[REDProp("indexThighL")]
public int IndexThighL { get; set;}

[REDProp("shinL")]
public CName ShinL { get; set;}

[REDProp("indexShinL")]
public int IndexShinL { get; set;}

[REDProp("footL")]
public CName FootL { get; set;}

[REDProp("indexFootL")]
public int IndexFootL { get; set;}

[REDProp("toeL")]
public CName ToeL { get; set;}

[REDProp("indexToeL")]
public int IndexToeL { get; set;}

[REDProp("thighR")]
public CName ThighR { get; set;}

[REDProp("indexThighR")]
public int IndexThighR { get; set;}

[REDProp("shinR")]
public CName ShinR { get; set;}

[REDProp("indexShinR")]
public int IndexShinR { get; set;}

[REDProp("footR")]
public CName FootR { get; set;}

[REDProp("indexFootR")]
public int IndexFootR { get; set;}

[REDProp("toeR")]
public CName ToeR { get; set;}

[REDProp("indexToeR")]
public int IndexToeR { get; set;}

[REDProp("pelvisUpDir")]
public EAxis PelvisUpDir { get; set;}

[REDProp("torso1UpDir")]
public EAxis Torso1UpDir { get; set;}

[REDProp("torso2UpDir")]
public EAxis Torso2UpDir { get; set;}

[REDProp("torso3UpDir")]
public EAxis Torso3UpDir { get; set;}

#endregion
}
}