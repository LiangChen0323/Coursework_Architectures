using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer.StateMachines
{
    public abstract class State
    {
        public abstract void Enter(object owner);
        public abstract void Exit(object owner);
        public abstract void Execute(object owner, GameTime gameTime);
        public virtual void Draw(object owner, GameTime gameTime, SpriteBatch spriteBatch) { }

        private List<Transition> m_Transitions = new List<Transition>();
        public List<Transition> Transitions
        {
            get { return m_Transitions; }
        }

        public void AddTransition(Transition transition)
        {
            m_Transitions.Add(transition);
        }

        public string Name
        {
            get;
            set;
        }
    }

    public class Transition
    {
        public readonly State NextState;
        public readonly Func<bool> Condition;   //Func<bool> = passing a function as a parameter. Bool is the return type of the function.

        public Transition(State nextState, Func<bool> condition)
        {
            NextState = nextState;
            Condition = condition;
        }
    }
}
