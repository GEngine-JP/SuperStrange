using strange.extensions.context.impl;

namespace Assets.coreScripts.ui
{
    public class UIRoot : ContextView
    {
        void Awake()
        {
            context = new UIContext(this);
        }
    }
}
