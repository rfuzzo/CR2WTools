using CR2W.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CHorseRiderSharedParams : IScriptable
{
#region RED Properties

[REDProp("rider")]
public Handle<CActor> Rider { get; set;}

[REDProp("horse")]
public Handle<CActor> Horse { get; set;}

[REDProp("mountStatus")]
public EVehicleMountStatus MountStatus { get; set;}

[REDProp("boat")]
public EntityHandle Boat { get; set;}

[REDProp("vehicleSlot")]
public EVehicleSlot VehicleSlot { get; set;}

        #endregion

        //FIXME abstract classes
        public override UInt16 Flags { get; set; }
        public override UInt32 Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e) { }
        public override void OnDeSerialize(IFile source, REDEventArgs e) { }
    }
}