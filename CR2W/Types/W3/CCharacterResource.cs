using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCharacterResource : CResource
{
#region RED Properties

[REDProp("charactersData")]
public Array<Ptr<CCharacter>> CharactersData { get; set;}

#endregion
}
}