﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Practical.Practical_7.Scripts.State
{
    public class StateMachine
    {
        private StateNode current;
        private Dictionary<Type, StateNode> nodes = new();
        public HashSet<ITransition> anyTransitions = new();

        public void Update()
        {
            var transition = GetTransition();
            if (transition != null)
                ChangeState(transition.To);
            current.State?.OnUpdate();
        }

        public void SetState(IState state)
        {
            current = nodes[state.GetType()];
            current.State?.OnEnter();
        }

        private void ChangeState(IState state)
        {
            if (state == current.State) return;
            current?.State?.OnExit();
            current = GetOrAddStateNode(state);
            current.State?.OnEnter();
        }

        public void At(IState from, IState to, IPredicate condition)
        {
            var fromNode = GetOrAddStateNode(from);
            fromNode.AddTransition(to, condition);
        }

        public void Any(IState to, IPredicate condition) { anyTransitions.Add(new Transition(to, condition)); }

        private StateNode GetOrAddStateNode(IState state)
        {
            var type = state.GetType();
            if (nodes.TryGetValue(type, out var node)) return node;
            node = new StateNode(state);
            nodes[type] = node;
            return node;
        }

        private ITransition GetTransition()
        {
            foreach (var transition in anyTransitions.Where(transition => transition.Condition.Evaluate()))
                return transition;
            return current.Transitions.FirstOrDefault(transition => transition.Condition.Evaluate());
        }

        private class StateNode
        {
            public IState State { get; }
            public HashSet<ITransition> Transitions { get; } = new();
            public StateNode(IState state) { State = state; }

            public void AddTransition(IState to, IPredicate condition) { Transitions.Add(new Transition(to, condition)); }
        }
    }
}