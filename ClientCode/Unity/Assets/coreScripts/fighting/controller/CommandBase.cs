using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace Assets.coreScripts.fighting.controller
{
    public class CommandBase : Command
    {
        ////IEventDispacher换成Signal实现
        //[Inject(ContextKeys.CONTEXT_DISPATCHER)]
        //public IEventDispatcher dispatcher { get; set; }

        //[Inject]
        //public IEvent evt { get; set; }

        /// <summary>
        /// 用于同步Command
        /// </summary>
        public override void Retain()
        {
            base.Retain();
        }

        /// <summary>
        /// 释放同步锁
        /// </summary>
        public override void Release()
        {
            base.Release();
        }
    }
}
