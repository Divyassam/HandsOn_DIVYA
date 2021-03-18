using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPgm
{
    public class State
    {
        public int Count { get; set; }
        public bool CurrentState { get; set; }
        public State()
        {
            Count = 0;
            CurrentState = true;
        }
    }
}
