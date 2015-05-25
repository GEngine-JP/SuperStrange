using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

namespace Assets.coreScripts.fighting.util
{
    public class GameLoop : MonoBehaviour,IGameTimer
    {
        private bool update = false;

        [Inject(ContextKeys.CONTEXT_DISPATCHER)]
        public IEventDispatcher dispatcher { get; set; }

        #region IGameTimer Members

        public void Start()
        {
            update = true;
        }

        public void Stop()
        {
            update = false;
        }

        #endregion

        /// <summary>
        /// 如果当前dispacher被注册且在游戏状态 执行游戏逻辑最外层循环
        /// </summary>
        void Update() 
        {
            if (dispatcher != null && update)
                dispatcher.Dispatch(GameConfig.CoreEvent.GAME_UPDATE);
        }

        void FixedUpdate()
        {
            if (dispatcher != null && update)
                dispatcher.Dispatch(GameConfig.CoreEvent.GAME_FIXEDDATE);
        }
    }
}
