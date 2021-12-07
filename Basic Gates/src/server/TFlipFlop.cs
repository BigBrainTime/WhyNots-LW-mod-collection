using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace STF
{
    public class TFlipFlop : LogicComponent
    {
        protected override void DoLogicUpdate() {
            if (base.Inputs[0].On){
                base.Outputs[0].On = !base.Outputs[0].On;
                return;
            }
        }
    }
}