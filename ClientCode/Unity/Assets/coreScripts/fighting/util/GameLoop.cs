using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

namespace Assets.coreScripts.fighting.util
{
    public class GameLoop : MonoBehaviour,IGameTimer
    {
        private bool update = false;

        //IEventDispacher换成Signal实现
        //[Inject(ContextKeys.CONTEXT_DISPATCHER)]
        //public IEventDispatcher dispatcher { get; set; }

        [Inject]
        public GameFixUpdateSignal fixUpdate { get; set; }

        [Inject]
        public GameUpdateSignal normalUpdate { get; set; }

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
            //IEventDispacher换成Signal实现
            //if (dispatcher != null && update)
            //    dispatcher.Dispatch(GameConfig.CoreEvent.GAME_UPDATE);

            if (normalUpdate!=null&&update)
            {
                Debug.Log("normalUpdate.Dispatch");
                normalUpdate.Dispatch();
            }
        }

        void FixedUpdate()
        {
            //IEventDispacher换成Signal实现
            //if (dispatcher != null && update)
            //    dispatcher.Dispatch(GameConfig.CoreEvent.GAME_FIXEDDATE);

            if (fixUpdate != null && update)
            {
                Debug.Log("fixUpdate.Dispatch");
                fixUpdate.Dispatch();
            }
        }
    }
}
