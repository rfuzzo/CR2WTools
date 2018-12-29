using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CDLCDefinition : CResource
{
#region RED Properties

[REDProp("id")]
public CName Id { get; set;}

[REDProp("localizedNameKey")]
public string LocalizedNameKey { get; set;}

[REDProp("localizedDescriptionKey")]
public string LocalizedDescriptionKey { get; set;}

[REDProp("mounters")]
public Array<Ptr<IGameplayDLCMounter>> Mounters { get; set;}

[REDProp("languagePacks")]
public Array<SDLCLanguagePack> LanguagePacks { get; set;}

[REDProp("initiallyEnabled")]
public bool InitiallyEnabled { get; set;}

[REDProp("visibleInDLCMenu")]
public bool VisibleInDLCMenu { get; set;}

[REDProp("requiredByGameSave")]
public bool RequiredByGameSave { get; set;}

#endregion
}
}