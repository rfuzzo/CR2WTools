using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CParticleInitializerSpawnSphere : IParticleInitializer
{
#region RED Properties

[REDProp("editorName")]
public string EditorName { get; set;}

[REDProp("editorColor")]
public Color EditorColor { get; set;}

[REDProp("editorGroup")]
public string EditorGroup { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("isShowing")]
public bool IsShowing { get; set;}

[REDProp("isSelected")]
public bool IsSelected { get; set;}

[REDProp("seed")]
public uint Seed { get; set;}

[REDProp("innerRadius")]
public Ptr<IEvaluatorFloat> InnerRadius { get; set;}

[REDProp("outerRadius")]
public Ptr<IEvaluatorFloat> OuterRadius { get; set;}

[REDProp("surfaceOnly")]
public bool SurfaceOnly { get; set;}

[REDProp("spawnPositiveX")]
public bool SpawnPositiveX { get; set;}

[REDProp("spawnNegativeX")]
public bool SpawnNegativeX { get; set;}

[REDProp("spawnPositiveY")]
public bool SpawnPositiveY { get; set;}

[REDProp("spawnNegativeY")]
public bool SpawnNegativeY { get; set;}

[REDProp("spawnPositiveZ")]
public bool SpawnPositiveZ { get; set;}

[REDProp("spawnNegativeZ")]
public bool SpawnNegativeZ { get; set;}

[REDProp("velocity")]
public bool Velocity { get; set;}

[REDProp("forceScale")]
public Ptr<IEvaluatorFloat> ForceScale { get; set;}

#endregion
}
}