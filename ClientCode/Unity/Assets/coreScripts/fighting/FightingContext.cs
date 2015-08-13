using Assets.coreScripts.fighting.controller;
using Assets.coreScripts.fighting.signal;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

namespace Assets.coreScripts.fighting
{
    public class FightingContext : MVCSContext
    {
        public FightingContext(MonoBehaviour view) : base(view)
        {
        }

        public FightingContext(MonoBehaviour view, ContextStartupFlags flags) : base(view, flags)
		{
		}

        /// <summary>
        /// 在postBindings()之后执行
        /// </summary>
        public override void Launch()
        {
            UnityEngine.Debug.Log("Launch...");
            base.Launch();
            
            injectionBinder.GetInstance<InitDataSignal>().Dispatch();
        }

        /// <summary>
        /// 在addCoreComponents()之后执行
        /// </summary>
        /// <returns></returns>
        public override IContext Start()
        {
            UnityEngine.Debug.Log("Start...");
            return base.Start();
        }

        /// <summary>
        /// 使用Signal 移除EventDispacher 如下bind
        /// injectionBinder.Bind<IEventDispatcher>().To<EventDispatcher>().ToSingleton().ToName(ContextKeys.CONTEXT_DISPATCHER);
        /// </summary>
        protected override void addCoreComponents()
        {
            base.addCoreComponents();
            injectionBinder.Unbind<ICommandBinder>();
            injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
        }

        /// <summary>
        /// 在mapBindings()之后执行
        /// </summary>
        protected override void postBindings()
        {
            base.postBindings();
        }

        /// <summary>
        /// 在Start()之后执行
        /// </summary>
        protected override void mapBindings()
        {
            //移除EventDispacher对应的Bind
            //commandBinder.Bind(GameConfig.CoreEvent.GAME_START).To<GameStartCommand>();
            //commandBinder.Bind(GameConfig.CoreEvent.GAME_OVER).To<GameOverCommand>();
            //commandBinder.Bind(GameConfig.CoreEvent.GAME_PAUSE).To<GamePauseCommand>();
            //commandBinder.Bind(GameConfig.CoreEvent.GAME_RESET).To<GameResetCommand>();

            //使用Signal实现Bind
            commandBinder.Bind<GameStartSignal>().To<GameStartCommand>();
            commandBinder.Bind<GameOverSignal>().To<GameOverCommand>();
            commandBinder.Bind<GamePauseSignal>().To<GamePauseCommand>();
            commandBinder.Bind<GameResetSignal>().To<GameResetCommand>();
            commandBinder.Bind<InitDataSignal>().To<InitBaseDataCommand>();

            injectionBinder.Bind<GameUpdateSignal>().ToSingleton();
            injectionBinder.Bind<GameFixUpdateSignal>().ToSingleton();



            if (this == Context.firstContext)
            {
                //移除EventDispacher对应的Bind
                //commandBinder.Bind(GameConfig.CoreEvent.GAME_EXIT).To<ApplicationExit>().Once();
                //commandBinder.Bind(ContextEvent.START).To<ApplicationStart>().To<InitBaseDataCommand>().InSequence().Once();

                //从UIContext中启动
                //commandBinder.Bind<AppStartSignal>().To<ApplicationStart>().To<InitBaseDataCommand>().InSequence().Once();
                //commandBinder.Bind<AppExitSignal>().To<ApplicationExit>().Once();
            }
        }

    }
}
