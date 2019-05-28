using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor.SceneManagement;

public class TestBattleScene {

    string BattleSceneName = "MainScene";

    [Test]
    public void TestBattleSceneSimplePasses() {
        // Use the Assert class to test conditions.
        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator TestBattleSceneBackgroundIsSet() {
      string expectedSkyboxName = "Green_1K_Resolution";
      EditorSceneManager.OpenScene("Assets/Scenes/MainScene.unity");
      yield return null;
      Debug.Log(RenderSettings.skybox.name);
      Assert.AreEqual(RenderSettings.skybox.name, expectedSkyboxName);
    }
}
