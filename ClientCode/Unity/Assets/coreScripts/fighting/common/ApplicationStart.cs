using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.coreScripts.fighting.common
{
    public class ApplicationStart:EventCommandBase
    {
        public override void Execute()
        {
            UnityEngine.Debug.Log("ApplicationStart Execute");
        }
    }
}
