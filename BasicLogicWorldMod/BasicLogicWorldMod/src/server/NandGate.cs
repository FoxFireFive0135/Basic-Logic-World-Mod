using LogicAPI.Server.Components;
using System;

namespace FoxFireFive_BasicLogicWorldMod.Server
{
    public class NandGate : LogicComponent
    {

        //protected override void Initialize() // useful for setup logic
        //{
        //    base.Initialize();
        //}

        // this is useful for not recomputing the logicupdate if a pin changes that has no effect on the output(s). In this case all pins can cause an output change, so i just set it to true
        //public override bool InputAtIndexShouldTriggerComponentLogicUpdates(int inputIndex)
        //{
        //    return true;
        //}

        protected override void DoLogicUpdate() // contains the main logic of the component
        {
            Outputs[0].On = !(Inputs[0].On && Inputs[1].On);
        }

        //public override void Dispose() // useful for Dispose'ing other objects that use unmanaged memory or stuff like Streams, network connections, etc. Generally you will not need this.
        //{
        //    base.Dispose();
        //}
    }
}