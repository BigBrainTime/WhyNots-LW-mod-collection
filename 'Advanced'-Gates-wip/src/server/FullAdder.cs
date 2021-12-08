using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace STFAG
{
    public class FullAdder : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            base.Outputs[0].On = (((base.Inputs[0].On & !base.Inputs[1].On) | (!base.Inputs[0].On & base.Inputs[1].On) & !base.Inputs[2].on) | (!((base.Inputs[0].On & !base.Inputs[1].On) | (!base.Inputs[0].On & base.Inputs[1].On)) & base.Inputs[2].on));
            base.Outputs[1].On = ((base.Inputs[0].On & base.Inputs[1].On) | (((base.Inputs[0].On & !base.Inputs[1].On) | (!base.Inputs[0].On & base.Inputs[1].On)) & base.Inputs[2].on));
        }
    }
}