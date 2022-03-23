using System;

namespace Managers
{
    public static class EventsManager
    {
        public static Action GameOver;
        public static Action<int> UpdateScore;
    }
}
