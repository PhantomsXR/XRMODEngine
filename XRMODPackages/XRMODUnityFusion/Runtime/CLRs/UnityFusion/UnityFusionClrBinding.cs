namespace UnityFusion.Runtime.Generated
{
    public class UnityFusionClrBinding
    {
        public static void Binding(Enviorment.AppDomain _app)
        {
            IAsyncStateMachineClassInheritanceAdaptor_Binding.Register(_app);
            MonoBehaviourAdapter_Binding_Adaptor_Binding.Register(_app);
            LitJson_JsonMapper_Binding.Register(_app);
            Vector3Binder_Binding.Register(_app);
            Vector2Binder_Binding.Register(_app);
            QuaternionBinder_Binding.Register(_app);
        }
    }
}