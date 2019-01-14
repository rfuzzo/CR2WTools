using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CGameWorld : CWorld
    {
        #region RED Properties

        [REDProp("startupCameraPosition")]
        public Vector StartupCameraPosition { get; set;}

        [REDProp("startupCameraRotation")]
        public EulerAngles StartupCameraRotation { get; set;}

        [REDProp("terrainClipMap")]
        public Ptr<CClipMap> TerrainClipMap { get; set;}

        [REDProp("newLayerGroupFormat")]
        public bool NewLayerGroupFormat { get; set;}

        [REDProp("hasEmbeddedLayerInfos")]
        public bool HasEmbeddedLayerInfos { get; set;}

        [REDProp("initialyHidenLayerGroups")]
        public Handle<C2dArray> InitialyHidenLayerGroups { get; set;}

        [REDProp("umbraScene")]
        public Handle<CUmbraScene> UmbraScene { get; set;}

        [REDProp("globalWater")]
        public Ptr<CGlobalWater> GlobalWater { get; set;}

        [REDProp("pathLib")]
        public Ptr<CPathLibWorld> PathLib { get; set;}

        [REDProp("worldDimensions")]
        public float WorldDimensions { get; set;}

        [REDProp("shadowConfig")]
        public CWorldShadowConfig ShadowConfig { get; set;}

        [REDProp("environmentParameters")]
        public SWorldEnvironmentParameters EnvironmentParameters { get; set;}

        [REDProp("soundBanksDependency", 2,0)]
        public Array<CName> SoundBanksDependency { get; set;}

        [REDProp("soundEventsOnAttach", 2,0)]
        public Array<StringAnsi> SoundEventsOnAttach { get; set;}

        [REDProp("soundEventsOnDetach", 2,0)]
        public Array<StringAnsi> SoundEventsOnDetach { get; set;}

        [REDProp("foliageScene")]
        public Ptr<CFoliageScene> FoliageScene { get; set;}

        [REDProp("playGoChunks", 2,0)]
        public Array<CName> PlayGoChunks { get; set;}

        [REDProp("minimapsPath")]
        public string MinimapsPath { get; set;}

        [REDProp("hubmapsPath")]
        public string HubmapsPath { get; set;}

        [REDProp("mergedGeometry")]
        public Ptr<CMergedWorldGeometry> MergedGeometry { get; set;}

        [REDProp("cookedExplorations")]
        public Handle<CCookedExplorations> CookedExplorations { get; set;}

        [REDProp("cookedWaypoints")]
        public Handle<CWayPointsCollectionsSet> CookedWaypoints { get; set;}

        #endregion
        
        //UNKNOWN BYTES
        // has a handle to the top-level layergroup
        public Handle<CLayerGroup> LayergroupHandle { get; set; }
        //public CLayerGroup Layergroup { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            Handle<CLayerGroup> temp = new Handle<CLayerGroup>();
            temp.Index = br.ReadInt32();
            LayergroupHandle = temp;
        }

      
    }
}