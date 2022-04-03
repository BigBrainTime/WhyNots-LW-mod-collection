using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

//output 0 is 7 seg input a, output 6 being 7 seg g. output 7 is decimal
//inputs 0-3 are bcd input a-d, and input 4 is decimal input

namespace STFAG
{
    public class BCD : LogicComponent
    {
        protected override async void DoLogicUpdate()
        {
            base.Outputs[0].On = ((base.Inputs[1].On & base.Inputs[3].On) | (!base.Inputs[1].On & !base.Inputs[3].On) | base.Inputs[0].On | base.Inputs[2].On);
            base.Outputs[1].On = ((base.Inputs[2].On & base.Inputs[3].On) | (!base.Inputs[2].On & !base.Inputs[3].On) | !base.Inputs[1].On);
            base.Outputs[2].On = (base.Inputs[1].On | !base.Inputs[2].On | base.Inputs[3].On);
            base.Outputs[3].On = (base.Inputs[0].On | (!base.Inputs[1].On & !base.Inputs[3].On) | (base.Inputs[2].On & !base.Inputs[3].On) | (!base.Inputs[1].On & base.Inputs[2].On) | (base.Inputs[1].On & !base.Inputs[2].On & base.Inputs[3].On));
            base.Outputs[4].On = (base.Inputs[2].On & !base.Inputs[3].On | (!base.Inputs[1].On & !base.Inputs[3].On));
            base.Outputs[5].On = ((!base.Inputs[2].On & !base.Inputs[3].On) | (base.Inputs[1].On & !base.Inputs[3].On) | (base.Inputs[1].On & !base.Inputs[2].On) | base.Inputs[0].On);
            base.Outputs[6].On = ((base.Inputs[2].On & !base.Inputs[3].On) | (base.Inputs[1].On & !base.Inputs[2].On) | base.Inputs[0].On | (!base.Inputs[1].On & base.Inputs[2].On));
            base.Outputs[7].On = base.Inputs[4].On;
        }
    }
}