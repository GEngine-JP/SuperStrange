using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace Assets.coreScripts.ui.common
{
    public class CommandBase:Command
    {
        //放弃EventBus使用Signal
        //[Inject(ContextKeys.CONTEXT_DISPATCHER)]
        //public IEventDispatcher dispatcher { get; set; }

        //[Inject]
        //public IEvent evt { get; set; }

        public override void Retain()
        {
            base.Retain();
        }

        public override void Release()
        {
            base.Release();
        }
    }
}
