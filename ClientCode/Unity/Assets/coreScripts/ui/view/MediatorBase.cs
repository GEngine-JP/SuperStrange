using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace Assets.coreScripts.ui.view
{
    public class MediatorBase:Mediator
    {
        public override void OnRegister()
        {
            InitListeners(true);
        }
        protected virtual void InitListeners(bool enable) { }
        protected virtual void OnClose() { InitListeners(false); }
        public override void OnRemove()
        {
            InitListeners(false);
            UnityEngine.Debug.Log("MediatorBase.OnRemove");
        }
    }
}
