using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using System;
using LogicWorld.Server.Circuitry;
using STF.Server;

namespace STFAG.Server
{
    public class Loader : ServerMod
    {
        protected override void Initialize()
        {
            Logger.Info("Advanced Gates initialized");
        }
    }
}