using Assets.coreScripts.fighting.util;
using strange.extensions.command.impl;

namespace Assets.coreScripts.fighting.controller
{
    public class GameOverCommand :Command
    {

        //[Inject]
        //public IGameTimer timer { get; set; }
        //public override void Execute()
        //{
        //    timer.Stop();
        //    UnityEngine.Debug.Log("GameOverCommand Execute");
        //}

        public override void Execute()
        {
            UnityEngine.Debug.Log("GameOverCommand Execute");
        }
    }
}
