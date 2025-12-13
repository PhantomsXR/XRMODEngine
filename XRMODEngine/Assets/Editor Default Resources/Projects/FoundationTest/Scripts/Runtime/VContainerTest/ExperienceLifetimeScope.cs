using System;
using System.Collections.Generic;
using FoundationTest.Runtime.EventReceiver;
using FoundationTest.Runtime.Networks;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using Object = UnityEngine.Object;

namespace FoundationTest.Runtime
{
    public class ExperienceLifetimeScope : XRMODBehaviour
    {
        private ExperiencePresenter experiencePresenter;
        private Action eventAction;
        private int[] values = new int[] {1, 2, 3};
        private SpawnTargetData spawnTargetData = new();
        public static IObjectResolver resolver;
        private SpawnerTest[] spawners = new SpawnerTest[1];

        private async void Awake()
        {
            if (!enabled) return;
            experiencePresenter = FindAnyObjectByType<ExperiencePresenter>();
            spawnTargetData.Register(new SpawnTargetType
            {
                TypeName = "Test",
                TargetTypeId = 0,
                TargetMeshesName = new string[]
                {
                    "TestMesh",
                }
            });
            var tmp_Container = new ContainerBuilder();
            tmp_Container.Register<PlainCShapeClass>(Lifetime.Scoped);
            tmp_Container.Register<HelloWorldService>(Lifetime.Scoped).Keyed("SayHello");
            tmp_Container.Register<IService, IService2, GoodByeService>(Lifetime.Scoped).Keyed("GoodBye");

            tmp_Container.Register<NetworkFactory>(Lifetime.Scoped);
            tmp_Container.Register<TestLogReceiver>(Lifetime.Scoped);
            tmp_Container.Register<BuildEventReceivers>(Lifetime.Singleton);
            tmp_Container.Register<EventReceiverFactory>(Lifetime.Singleton);
            tmp_Container.RegisterInstance<int[]>(values);
            tmp_Container.RegisterInstance(spawnTargetData);
            tmp_Container.RegisterInstance<IService, IService2>(spawnTargetData);
            tmp_Container.RegisterInstance<SpawnTargetData, IService, IService2>(spawnTargetData);
            spawners = FindObjectsByType<SpawnerTest>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            tmp_Container.RegisterInstance(spawners);
            tmp_Container.RegisterComponent(experiencePresenter);

            resolver = tmp_Container.Build();

            resolver.Resolve<EventReceiverFactory>().Do();
            resolver.InjectGameObject(experiencePresenter.gameObject);
            resolver.Inject(experiencePresenter);
            resolver.Inject(values);


            var tmp_InjectAtRuntimeGo =
                await SharedData.GetInstance.XRMODAPI.LoadAssetAsync<GameObject>("InjectAtRuntime");
            var tmp_Go = Object.Instantiate(tmp_InjectAtRuntimeGo, SharedData.GetInstance.XRMODAPI.GetProcessContainer);
            resolver.Inject(tmp_Go.GetComponent<SpawnTeset2>());
        }
    }
}