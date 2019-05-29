using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor.SceneManagement;

public class TestBattleScene {

    string BattleSceneLocation = "Assets/Scenes/MainScene.unity";

    [Test]
    public void TestBattleSceneSimplePasses() {
        // Use the Assert class to test conditions.
        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator TestBattleSceneBackgroundIsSet() {
      string expectedSkyboxName = "Green_1K_Resolution";
      EditorSceneManager.OpenScene(BattleSceneLocation);
      yield return null;
      Debug.Log(RenderSettings.skybox.name);
      Assert.AreEqual(RenderSettings.skybox.name, expectedSkyboxName);
    }
}
