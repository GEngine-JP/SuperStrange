using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace Assets.coreScripts.fighting.common
{
    public class EventCommandBase:Command
    {
        [Inject(ContextKeys.CONTEXT_DISPATCHER)]
        public IEventDispatcher dispatcher { get; set; }

        [Inject]
        public IEvent evt { get; set; }

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
