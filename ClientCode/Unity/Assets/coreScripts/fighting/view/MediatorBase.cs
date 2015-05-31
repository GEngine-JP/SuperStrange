using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace Assets.coreScripts.fighting.view
{
    public class MediatorBase:Mediator
    {
        //[Inject(ContextKeys.CONTEXT_DISPATCHER)]
        //public IEventDispatcher dispatcher { get; set; }

        [Inject]
        public GameStartSignal gameStartSignal { get; set; }
        [Inject]
        public GameResetSignal gameResetSignal { get; set; }
        [Inject]
        public GamePauseSignal gamePauseSignal { get; set; }
        [Inject]
        public GameOverSignal gameOverSignal { get; set; }

        public override void OnRegister()
        {
            InitLisenters(true);
        }

        protected virtual void InitLisenters(bool enable)
        {
            if (enable)
            {
                gameResetSignal.AddListener(OnGameReset);
                gameStartSignal.AddListener(OnGameStart);
                gameOverSignal.AddListener(OnGameOver);
                gamePauseSignal.AddListener(OnGamePause);
            }
            else 
            {
                gameResetSignal.RemoveListener(OnGameReset);
                gameStartSignal.RemoveListener(OnGameStart);
                gameOverSignal.RemoveListener(OnGameOver);
                gamePauseSignal.RemoveListener(OnGamePause);
            }

        }

        protected virtual void OnGameReset() { InitLisenters(true); }
        protected virtual void OnGameOver() { InitLisenters(false); }
        protected virtual void OnGameStart() { InitLisenters(false); }
        protected virtual void OnGamePause() { InitLisenters(false); }

        public override void OnRemove() { InitLisenters(false); }

        protected virtual void InitData() { }
    }
}
