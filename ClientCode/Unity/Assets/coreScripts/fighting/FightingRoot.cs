using System;
using strange.extensions.context.api;
using strange.extensions.context.impl;

namespace Assets.coreScripts.fighting
{
    public class FightingRoot:ContextView
    {
        void Awake()
        {
            context = new FightingContext(this);
        }
    }
}
