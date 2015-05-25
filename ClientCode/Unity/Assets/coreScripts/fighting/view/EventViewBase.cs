using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace Assets.coreScripts.fighting.view
{
   public  class EventViewBase:View
    {
       [Inject]
       public IEventDispatcher dispatcher { get; set; }
    }
}
