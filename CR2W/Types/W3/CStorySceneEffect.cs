using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEffect : IStorySceneItem
{
#region RED Properties

[REDProp("id")]
public CName Id { get; set;}

[REDProp("particleSystem")]
public Soft<CParticleSystem> ParticleSystem { get; set;}

#endregion
}
}