using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using strange.extensions.signal.impl;

namespace Assets.coreScripts.ui.view
{
    public class MenuView : ViewBase
    {
        public Signal testClick = new Signal();
        public Signal switchScene = new Signal();
        public Signal loadConfig = new Signal();

        public Signal<string> InternalTest = new Signal<string>();

        public void Test() { testClick.Dispatch(); }
        public void SwitchScene() { switchScene.Dispatch(); }
        public void LoadConfig() { loadConfig.Dispatch(); }
        public void InternalViewTest() { InternalTest.Dispatch("keyle:String"); }
    }
}
