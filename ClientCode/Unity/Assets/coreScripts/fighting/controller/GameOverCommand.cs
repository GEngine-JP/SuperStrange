using Assets.coreScripts.fighting.util;
using strange.extensions.command.impl;

namespace Assets.coreScripts.fighting.controller
{
    public class GameOverCommand : EventCommand
    {

        [Inject]
        public IGameTimer timer { get; set; }
        public override void Execute()
        {
            timer.Stop();
            UnityEngine.Debug.Log("GameOverCommand Execute");
        }
    }
}
