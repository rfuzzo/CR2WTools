using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCharacter : CObject
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("parentCharacter")]
public Ptr<CCharacter> ParentCharacter { get; set;}

[REDProp("i_voiceTag")]
public CName I_voiceTag { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("entityTemplate")]
public Soft<CEntityTemplate> EntityTemplate { get; set;}

#endregion
}
}