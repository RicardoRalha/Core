using System;
using System.Collections.Generic;
using UnityEngine;

namespace RicardoRalha.Core.StateMachine
{
    public abstract class StateMachine : MonoBehaviour
    {
        protected readonly Dictionary<Type, IBaseState> _states = new Dictionary<Type, IBaseState>();

        protected IBaseState _currentState;

        protected abstract void Start();

        private void FixedUpdate()
        {
            _currentState.FixedUpdate();
        }   

        private void Update()
        {
            Type newStateType = _currentState.Update();

            TransitionToState(newStateType);
        }

        private void TransitionToState(Type newStateType)
        {
            if (newStateType == _currentState.GetType())
            {
                return;
            }
            
            IBaseState newState = _states[newStateType];
            
            _currentState.Exit();

            _currentState = newState;
            
            _currentState.Enter();
        }
    }
}
