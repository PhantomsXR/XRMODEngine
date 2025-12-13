using Goap.Agent.Core;
using Goap.Agent.Runtime;
using Goap.Runtime;
using UnityEngine;

namespace FoundationTest.Runtime
{
    [GoapId("PickupPear-353c4482-3ab1-4f6e-8239-c0e53414083d")]
    public class PickupPearAction : GoapActionBase<PickupPearAction.Data>
    {
        // This method is called when the action is created
        // This method is optional and can be removed
        public override Data CreateData()
        {
            return new Data();
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
            return ActionRunState.WaitThenComplete(0.5f);
        }

        // This method is called when the action is completed
        // This method is optional and can be removed
        public override void Complete(IMonoAgent agent, Data data)
        {
            if (data.Target is not TransformTarget tmp_TransformTarget)
                return;

            data.DataBehaviour.pearCount++;
            tmp_TransformTarget.Transform.gameObject.SetActive(false);
            // Object.Destroy();
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