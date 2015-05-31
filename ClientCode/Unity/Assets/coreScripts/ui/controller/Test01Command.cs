using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.coreScripts.ui.controller
{
    public class Test01Command :CommandBase
    {
        [Inject]
        public int value { get; set; }
        [Inject]
        public string str { get; set; }

        public override void Execute()
        {
            UnityEngine.Debug.Log(string.Format("Look the value is {0} and the another is {1}", value, str));

        }
    }
}
