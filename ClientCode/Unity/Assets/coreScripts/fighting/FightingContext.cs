using Assets.coreScripts.fighting.common;
using Assets.coreScripts.fighting.controller;
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

        protected override void mapBindings()
        {

            commandBinder.Bind(GameConfig.CoreEvent.GAME_START).To<GameStartCommand>();
            commandBinder.Bind(GameConfig.CoreEvent.GAME_OVER).To<GameOverCommand>();
            commandBinder.Bind(GameConfig.CoreEvent.GAME_PAUSE).To<GamePauseCommand>();
            commandBinder.Bind(GameConfig.CoreEvent.GAME_RESET).To<GameResetCommand>();
           
            if (this == Context.firstContext)
            {
                commandBinder.Bind(GameConfig.CoreEvent.GAME_EXIT).To<ApplicationExit>().Once();
                commandBinder.Bind(ContextEvent.START).To<ApplicationStart>().To<InitBaseDataCommand>().InSequence().Once();
            }
        }

    }
}
