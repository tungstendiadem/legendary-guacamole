using System;

namespace State
{
    public class Handler
    {
        public AbstractState currentState;

        public AbstractState CurrentState { get => currentState; set => currentState = value; }

        void stateChange()
        {
            if(currentState is StateOne){ currentState = new StateTwo(); }

            if(currentState is StateTwo){ currentState = new StateN(); }

            if(currentState is StateN){ currentState = new StateOne(); }

            // Might an enum allow us to increment the state?
            // How would we handle branching states
        }

        void setState(AbstractState input)
        {
            currentState = input;
        }

        public Handler()
        {
            currentState = new StateOne();
        }
    }


}
