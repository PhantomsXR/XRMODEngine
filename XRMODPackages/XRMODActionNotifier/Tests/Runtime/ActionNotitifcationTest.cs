using System;
using System.Collections;
using System.Threading.Tasks;
using NUnit.Framework;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.TestTools;

public class ActionNotitifcationTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void ActionNotitifcationTestSimplePasses()
    {
        // Use the Assert class to test conditions
        ActionNotificationCenter.DefaultCenter.AddAsyncObserver(AsyncRunnerTest, "Test");
        Task.Run(async () =>
        {
            var tmp_Result = await ActionNotificationCenter.DefaultCenter.PostNotificationAsync("Test",
                new BaseNotificationData()
                {
                    BaseData = "Hi,Test",
                });
            Debug.Log(tmp_Result[0].ToString());
        });
    }

    private async Task<object> AsyncRunnerTest(BaseNotificationData _arg)
    {
        await Task.Delay(2000);
        return $"Wait 2 seconds:{_arg.BaseData}";
    }


    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ActionNotitifcationTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}