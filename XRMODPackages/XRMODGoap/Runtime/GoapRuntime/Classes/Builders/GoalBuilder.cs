using System;
using System.Collections.Generic;
using Goap.Core;
using UnityEngine;

namespace Goap.Runtime
{
    public class GoalBuilder<T> : GoalBuilder
        where T : IGoal
    {
        public GoalBuilder(WorldKeyBuilder worldKeyBuilder) : base(typeof(T), worldKeyBuilder)
        {
        }

        /// <summary>
        ///     Sets the base cost for the goal.
        /// </summary>
        /// <param name="baseCost">The base cost.</param>
        /// <returns>The current instance of <see cref="GoalBuilder{T}" />.</returns>
        public GoalBuilder<T> SetBaseCost(float baseCost)
        {
            this.config.BaseCost = baseCost;
            return this;
        }

        /// <summary>
        ///     Adds a condition to the goal.
        /// </summary>
        /// <typeparam name="TWorldKey">The type of the world key.</typeparam>
        /// <param name="comparison">The comparison type.</param>
        /// <param name="amount">The amount for the condition.</param>
        /// <returns>The current instance of <see cref="GoalBuilder{T}" />.</returns>
        public GoalBuilder<T> AddCondition<TWorldKey>(Comparison comparison, int amount)
            where TWorldKey : IWorldKey
        {
            this.conditions.Add(new Condition(this.worldKeyBuilder.GetKey<TWorldKey>(), comparison, amount));
            return this;
        }

        /// <summary>
        ///     Sets the callback for the goal. This will be called when the goal is created.
        /// </summary>
        /// <param name="callback">The callback action.</param>
        /// <returns>The current instance of <see cref="GoalBuilder{T}" />.</returns>
        public GoalBuilder<T> SetCallback(Action<T> callback)
        {
            this.config.Callback = (obj) => callback((T) obj);
            return this;
        }
    }

    public class GoalBuilder
    {
        protected readonly GoalConfig config;
        protected readonly List<ICondition> conditions = new();
        protected readonly WorldKeyBuilder worldKeyBuilder;

        public GoalBuilder(Type _type, WorldKeyBuilder _worldKeyBuilder)
        {
            this.worldKeyBuilder = _worldKeyBuilder;
            this.config = new GoalConfig(_type)
            {
                BaseCost = 1,
                ClassType = _type.AssemblyQualifiedName,
            };
        }

        /// <summary>
        ///     Builds the goal configuration.
        /// </summary>
        /// <returns>The built <see cref="IGoalConfig" />.</returns>
        public IGoalConfig Build()
        {
            this.config.Conditions = this.conditions;
            return this.config;
        }

        public static GoalBuilder<TGoal> Create<TGoal>(WorldKeyBuilder _worldKeyBuilder)
            where TGoal : IGoal
        {
            return new GoalBuilder<TGoal>(_worldKeyBuilder);
        }

        public static GoalBuilder Create(Type _goal, WorldKeyBuilder _worldKeyBuilder)
        {
            return new GoalBuilder(_goal, _worldKeyBuilder);
        }
        
        public GoalBuilder SetBaseCost(float _baseCost)
        {
            this.config.BaseCost = _baseCost;
            return this;
        }

        public GoalBuilder AddCondition(Type _worldKeyType, Comparison _comparison, int _amount)
        {
            this.conditions.Add(new Condition(this.worldKeyBuilder.GetKey(_worldKeyType), _comparison, _amount));
            return this;
        }

        public GoalBuilder SetCallback(Action<object> _callback)
        {
            this.config.Callback = _callback;
            return this;
        }

   
    }
}