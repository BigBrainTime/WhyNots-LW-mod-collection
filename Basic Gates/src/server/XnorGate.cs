using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace STF
{
    public class XnorGate : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            base.Outputs[0].On = !((base.Inputs[0].On ^ base.Inputs[1].On));
        }
    }
}