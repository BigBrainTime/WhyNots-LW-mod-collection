using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;
using System;

namespace STFAG
{
    public class CAdder : LogicComponent
    {
        protected override async void DoLogicUpdate()
        {
            string data = "";
            string bin = "";
            int decimalValue = 0;
            int i;

            for (i = 0; i < 4; i++)
            {
                if (base.Inputs[i].On == true)
                {
                    data += "1";
                }
                else
                {
                    data += "0";
                }
            }

            char[] charArray = data.ToCharArray();
            Array.Reverse(charArray);
            data = string.Join("", charArray);

            decimalValue = Convert.ToInt32(data, 2);

            if (decimalValue > 4)
            {
                decimalValue += 3;
            }

            bin = Convert.ToString(decimalValue, 2);

            Logger.Info(bin + " raw: " + decimalValue.ToString());

            charArray = bin.ToCharArray();
            Array.Reverse(charArray);
            bin = string.Join("", charArray);

            for (i = 0; i < 4; i++)
            {
                if (i < bin.Length)
                {
                    if (bin[i].ToString() == "0")
                    {
                        base.Outputs[i].On = false;
                    }
                    else
                    {
                        base.Outputs[i].On = true;
                    }
                }
                else
                {
                    base.Outputs[i].On = false;
                }
            }
        }
    }
}