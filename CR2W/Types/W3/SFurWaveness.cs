using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFurWaveness 
{
#region RED Properties

[REDProp("waveScale")]
public float WaveScale { get; set;}

[REDProp("waveScaleTex")]
public Handle<CBitmapTexture> WaveScaleTex { get; set;}

[REDProp("waveScaleTexChannel")]
public EHairTextureChannel WaveScaleTexChannel { get; set;}

[REDProp("waveScaleNoise")]
public float WaveScaleNoise { get; set;}

[REDProp("waveFreq")]
public float WaveFreq { get; set;}

[REDProp("waveFreqTex")]
public Handle<CBitmapTexture> WaveFreqTex { get; set;}

[REDProp("waveFreqTexChannel")]
public EHairTextureChannel WaveFreqTexChannel { get; set;}

[REDProp("waveFreqNoise")]
public float WaveFreqNoise { get; set;}

[REDProp("waveRootStraighten")]
public float WaveRootStraighten { get; set;}

[REDProp("waveStrand")]
public float WaveStrand { get; set;}

[REDProp("waveClump")]
public float WaveClump { get; set;}

#endregion
}
}