using Goap.Agent.Core;
using Goap.Agent.Runtime;
using Goap.Runtime;
using UnityEngine;

namespace FoundationTest.Runtime
{
    [GoapId("Eat-904b8d60-1d19-489b-bf51-b8a0c99f6533")]
    public class EatAction : GoapActionBase<EatAction.Data>
    {
        // This method is called when the action is created
        // This method is optional and can be removed
        public override Data CreateData()
        {
            return new Data();
        }


        // This method is called when the action is completed
        // This method is optional and can be removed
        public override IActionRunState Perform(IMonoAgent agent, Data data, IActionContext context)
        {
            return ActionRunState.WaitThenComplete(5f);
        }

        public override void Complete(IMonoAgent agent, Data data)
        {
            data.DataBehaviour.pearCount--;
            data.DataBehaviour.hunger = 0f;
        }


        // The action class itself must be stateless!
        // All data should be stored in the data class
        public class Data : IActionData
        {
            public ITarget Target { get; set; }
            [GetComponent] public DataBehaviour DataBehaviour { get; set; }
        }
    }
}