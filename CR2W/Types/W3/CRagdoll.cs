using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml;
using CR2W.IO;


namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]public class CRagdoll : CResource
    {
        [REDProp("windScaler")]
        public float WindScaler { get; set; }

        [REDProp("densityScaler")]
        public float DensityScaler { get; set; }

        [REDProp("autoStopDelay")]
        public float AutoStopDelay { get; set; }

        [REDProp("autoStopTime")]
        public float AutoStopTime { get; set; }

        [REDProp("autoStopSpeed")]
        public float AutoStopSpeed { get; set; }

        [REDProp("resetDampingAfterStop")]
        public bool ResetDampingAfterStop { get; set; }

        [REDProp("forceWakeUpOnAttach")]
        public bool ForceWakeUpOnAttach { get; set; }

        //No idea about this type - rttidump does not have it.
        //and no w2ragdoll file has this type used.
        //[W3Type("customDynamicGroup")]
        //public CPhysicalCollision CustomDynamicGroup { get; set; }

        [REDProp("disableConstrainsTwistAxis")]
        public bool DisableConstrainsTwistAxis { get; set; }

        [REDProp("disableConstrainsSwing1Axis")]
        public bool DisableConstrainsSwing1Axis { get; set; }

        [REDProp("disableConstrainsSwing2Axis")]
        public bool DisableConstrainsSwing2Axis { get; set; }

        [REDProp("jointBounce")]
        public float JointBounce { get; set; }

        [REDProp("modifyTwistLower")]
        public float ModifyTwistLower { get; set; }

        [REDProp("modifyTwistUpper")]
        public float ModifyTwistUpper { get; set; }

        [REDProp("modifySwingY")]
        public float ModifySwingY { get; set; }

        [REDProp("modifySwingZ")]
        public float ModifySwingZ { get; set; }

        [REDProp("projectionIterations")]
        public Int32 ProjectionIterations { get; set; }

        public XmlDocument Data { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            var length = br.ReadInt32();
            var xmlstr = Encoding.UTF8.GetString(br.ReadBytes(length));

            Data = new XmlDocument();
            Data.LoadXml(xmlstr);
        }
    }
}