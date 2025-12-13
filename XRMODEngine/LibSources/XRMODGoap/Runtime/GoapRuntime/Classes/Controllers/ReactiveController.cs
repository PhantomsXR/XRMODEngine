using Goap.Core;
using UnityEngine;

namespace Goap.Runtime
{
    public class ReactiveController : IGoapController
    {
        private IGoap goap;

        public void Initialize(IGoap goap)
        {
            this.goap = goap;
            this.goap.Events.OnAgentResolve += this.OnAgentResolve;
            this.goap.Events.OnNoActionFound += this.OnNoActionFound;
        }

        public void Disable()
        {
            if (this.goap.IsNull())
                return;

            if (this.goap?.Events == null)
                return;

            this.goap.Events.OnAgentResolve -= this.OnAgentResolve;
            this.goap.Events.OnNoActionFound -= this.OnNoActionFound;
        }

        public void OnUpdate()
        {
            foreach (var (type, runner) in this.goap.AgentTypeRunners)
            {
                var queue = type.Agents.GetQueue();

                runner.Run(queue);
            }

            for (int tmp_Idx = 0; tmp_Idx < goap.Agents.Count; tmp_Idx++)
            {
                var tmp_Agent = goap.Agents[tmp_Idx];
                if (tmp_Agent.IsNull())
                    continue;

                if (tmp_Agent.Receiver == null)
                    continue;
                if (tmp_Agent.Receiver.IsPaused)
                    continue;

                // Update the action sensors for the agent
                tmp_Agent.AgentType.SensorRunner.SenseLocal(tmp_Agent,
                    tmp_Agent.Receiver.ActionState.Action as IGoapAction);
            }
        }

        public void OnLateUpdate()
        {
            foreach (var runner in this.goap.AgentTypeRunners.Values)
            {
                runner.Complete();
            }
        }

        private void OnNoActionFound(IMonoGoapActionProvider actionProvider, IGoalRequest request)
        {
            this.Enqueue(actionProvider);
        }

        private void OnAgentResolve(IMonoGoapActionProvider actionProvider)
        {
            this.Enqueue(actionProvider);
        }

        private void Enqueue(IMonoGoapActionProvider actionProvider)
        {
            actionProvider.AgentType?.Agents.Enqueue(actionProvider);
        }
    }
}