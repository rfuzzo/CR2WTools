using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFurGraphicalMaterials 
{
#region RED Properties

[REDProp("color")]
public SFurColor Color { get; set;}

[REDProp("diffuse")]
public SFurDiffuse Diffuse { get; set;}

[REDProp("specular")]
public SFurSpecular Specular { get; set;}

[REDProp("glint")]
public SFurGlint Glint { get; set;}

[REDProp("shadow")]
public SFurShadow Shadow { get; set;}

#endregion
}
}