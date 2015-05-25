
using Assets.coreScripts.fighting.util;
using strange.extensions.context.api;
using UnityEngine;
namespace Assets.coreScripts.fighting.controller
{
    public class InitBaseDataCommand:EventCommandBase
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }

        public override void Execute()
        {
            IGameTimer timer = contextView.AddComponent<GameLoop>();
            injectionBinder.Bind<IGameTimer>().ToValue(timer);


            Debug.Log("InitBaseDataCommand Execute");
        }

    }
}
