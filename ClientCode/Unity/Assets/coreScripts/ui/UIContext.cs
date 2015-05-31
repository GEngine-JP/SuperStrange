using Assets.coreScripts.ui.common;
using Assets.coreScripts.ui.controller;
using Assets.coreScripts.ui.view;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

namespace Assets.coreScripts.ui
{
    public class UIContext : MVCSContext
    {
        public UIContext(MonoBehaviour view) : base(view) { }

        public UIContext(MonoBehaviour view, ContextStartupFlags flags) : base(view, flags) { }

        protected override void addCoreComponents()
        {
            base.addCoreComponents();
            injectionBinder.Unbind<ICommandBinder>();
            injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
        }

        protected override void mapBindings()
        {
            mediationBinder.Bind<MenuView>().To<MenuMediator>();

            injectionBinder.Bind<GameStartSignal>().CrossContext().ToSingleton();
            injectionBinder.Bind<GameOverSignal>().CrossContext().ToSingleton();
            injectionBinder.Bind<GamePauseSignal>().CrossContext().ToSingleton();
            injectionBinder.Bind<GameResetSignal>().CrossContext().ToSingleton();

            injectionBinder.Bind<GameUpdateSignal>().ToSingleton();
            injectionBinder.Bind<GameFixUpdateSignal>().ToSingleton();

            commandBinder.Bind<InitDataSignal>().To<InitBaseDataCommand>().Once();

            commandBinder.Bind<Test01Signal>().To<Test01Command>();
           

            if (this == Context.firstContext)
            {
                //从UIContext中启动
                commandBinder.Bind<AppStartSignal>().To<ApplicationStart>().Once();
                commandBinder.Bind<AppExitSignal>().To<ApplicationExit>().Once();
            }
        }
    }
}
