using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.coreScripts.ui.view
{
    public class MenuMediator:MediatorBase
    {
        [Inject]
        public MenuView view { get; set; }
        [Inject]
        public InitDataSignal dataCmd { get; set; }
        [Inject]
        public Test01Signal test01 { get; set; }


        protected override void InitListeners(bool enable)
        {
            base.InitListeners(enable);

            if (enable)
            {
                view.testClick.AddListener(Test_Click);
                view.switchScene.AddListener(Switch_Click);
                view.loadConfig.AddListener(Load_Click);
                view.InternalTest.AddListener(InternalViewTest_Click);
            }
            else 
            {
                view.testClick.RemoveListener(Test_Click);
                view.switchScene.RemoveListener(Switch_Click);
                view.loadConfig.RemoveListener(Load_Click);
                view.InternalTest.AddListener(InternalViewTest_Click);
            }
        }

        private void Load_Click()
        {
            dataCmd.Dispatch();
        }

        private void Switch_Click()
        {
            UnityEngine.Debug.Log("switch_click");
        }

        private void Test_Click()
        {
            test01.Dispatch("keyle:String", 21);
        }


        private void InternalViewTest_Click(string str)
        {
            UnityEngine.Debug.Log(str);
        }
    }
}
