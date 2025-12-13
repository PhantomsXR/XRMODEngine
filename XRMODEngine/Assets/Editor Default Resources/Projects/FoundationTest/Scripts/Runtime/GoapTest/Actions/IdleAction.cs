using Goap.Agent.Core;
using Goap.Runtime;
using UnityEngine;

namespace FoundationTest.Runtime
{
    [GoapId("Idle-51fd6a1c-97eb-4e9c-a6b1-a19092ec8b36")]
    public class IdleAction : GoapActionBase<IdleAction.Data>
    {
        // This method is called when the action is created
        // This method is optional and can be removed
        public override void Created()
        {
            
        }

        // This method is called every frame before the action is performed
        // If this method returns false, the action will be stopped
        // This method is optional and can be removed
        public override bool IsValid(IActionReceiver agent, Data data)
        {
            return true;
        }

        // This method is called when the action is started
        // This method is optional and can be removed
        public override void Start(IMonoAgent agent, Data data)
        {
            data.Timer = Random.Range(0.5f, 1.5f);
        }

        // This method is called once before the action is performed
        // This method is optional and can be removed
        public override void BeforePerform(IMonoAgent agent, Data data)
        {
        }

        // This method is called every frame while the action is running
        // This method is required
        public override IActionRunState Perform(IMonoAgent agent, Data data, IActionContext context)
        {
            if (data.Timer <= 0f)
                // Return completed to stop the action
                return ActionRunState.Completed;

            // Lower the timer for the next frame
            data.Timer -= context.DeltaTime;

            // Return continue to keep the action running
            return ActionRunState.Continue;
        }

        // This method is called when the action is completed
        // This method is optional and can be removed
        public override void Complete(IMonoAgent agent, Data data)
        { 
        }

        // This method is called when the action is stopped
        // This method is optional and can be removed
        public override void Stop(IMonoAgent agent, Data data)
        {
        }

        // This method is called when the action is completed or stopped
        // This method is optional and can be removed
        public override void End(IMonoAgent agent, Data data)
        {
        }

        public override Data CreateData()
        {
            return new Data();
        }


        // The action class itself must be stateless!
        // All data should be stored in the data class
        public class Data : IActionData
        {
            public ITarget Target { get; set; }
            public float Timer;
        }
    }
}