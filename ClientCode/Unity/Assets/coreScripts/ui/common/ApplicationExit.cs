using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.coreScripts.ui.common
{
    public class ApplicationExit:CommandBase
    {
        public override void Execute()
        {
            UnityEngine.Debug.Log("ApplicationExit Execute");
        }
    }
}
