using System;

namespace RicardoRalha.Core.StateMachine
{
    public interface IBaseState
    {
	    void Enter();
	    void FixedUpdate();
	    Type Update();
	    void Exit();
    }
}
