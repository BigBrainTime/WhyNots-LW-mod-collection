using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace STF
{
    public class SRLatch : LogicComponent
    {
        protected override void DoLogicUpdate() {
            if (base.Inputs[0].On){
                base.Outputs[0].On = false;
                return;
            }
            else if (base.Inputs[1].On){
                base.Outputs[0].On = true;
                return;
            }
        }
    }
}