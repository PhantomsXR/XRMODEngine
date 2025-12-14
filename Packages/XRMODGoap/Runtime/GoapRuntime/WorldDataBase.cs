using System;
using System.Collections.Generic;
using Goap.Agent.Core;
using Goap.Agent.Runtime;
using Goap.Core;
using UnityEngine;

namespace Goap.Runtime
{
    public abstract class WorldDataBase : IWorldData
    {
        protected abstract bool IsLocal { get; }
        public Dictionary<Type, IWorldDataState<int>> States { get; } = new();
        public Dictionary<Type, IWorldDataState<ITarget>> Targets { get; } = new();

        public ITarget GetTarget(IGoapAction action)
        {
            if (action == null)
                return null;

            if (action.Config.Target == null)
                return null;

            return this.GetTargetValue(TypeReSolveHelper.ResolveType(action.Config.Target));
        }

        public bool IsTrue<TWorldKey>(Comparison comparison, int value)
        {
            return this.IsTrue(typeof(TWorldKey), comparison, value);
        }

        public bool IsTrue(IWorldKey worldKey, Comparison comparison, int value)
        {
            return this.IsTrue(TypeReSolveHelper.ResolveType(worldKey), comparison, value);
        }

        public bool IsTrue(Type worldKey, Comparison comparison, int value)
        {
            var (exists, state) = this.GetWorldValue(worldKey);

            if (!exists)
                return false;

            switch (comparison)
            {
                case Comparison.GreaterThan:
                    return state > value;
                case Comparison.GreaterThanOrEqual:
                    return state >= value;
                case Comparison.SmallerThan:
                    return state < value;
                case Comparison.SmallerThanOrEqual:
                    return state <= value;
            }

            return false;
        }

        public void SetState(IWorldKey key, int state)
        {
            this.SetState(TypeReSolveHelper.ResolveType(key), state);
        }

        public void SetState<TKey>(int state) where TKey : IWorldKey
        {
            this.SetState(typeof(TKey), state);
        }

        public void SetState(Type key, int state)
        {
            if (key == null)
                return;

            if (this.States.ContainsKey(key))
            {
                this.States[key].Value = state;
                this.States[key].Timer.Touch();
                return;
            }

            this.States.Add(key, new WorldDataState<int>
            {
                Key = key,
                Value = state,
                IsLocal = this.IsLocal,
            });
        }

        public void SetTarget(ITargetKey key, ITarget target)
        {
            this.SetTarget(key.GetType(), target);
        }

        public void SetTarget<TKey>(ITarget target) where TKey : ITargetKey
        {
            this.SetTarget(typeof(TKey), target);
        }

        public void SetTarget(Type key, ITarget target)
        {
            try
            {
                if (key == null)
                    return; 
                if (this.Targets.ContainsKey(key))
                {
                    this.Targets[key].Value = target;
                    this.Targets[key].Timer.Touch();
                    return;
                }

                this.Targets.Add(key, new WorldDataState<ITarget>
                {
                    Key = key,
                    Value = target,
                    IsLocal = this.IsLocal,
                });
            }
            catch (Exception tmp_Exception)
            {
                Debug.Log(tmp_Exception);
                throw;
            }
        }

        public (bool Exists, int Value) GetWorldValue<TKey>(TKey worldKey) where TKey : IWorldKey =>
            this.GetWorldValue(TypeReSolveHelper.ResolveType(worldKey));

        public abstract (bool Exists, int Value) GetWorldValue(Type worldKey);
        public abstract ITarget GetTargetValue(Type targetKey);
        public abstract IWorldDataState<ITarget> GetTargetState(Type targetKey);
        public abstract IWorldDataState<int> GetWorldState(Type worldKey);
    }

    public class WorldDataState<T> : IWorldDataState<T>
    {
        public bool IsLocal { get; set; }
        public Type Key { get; set; }
        public T Value { get; set; }
        public ITimer Timer { get; } = new Timer();
    }
}