
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestAsteroidField: PrefabTest {

	public TestAsteroidField() {
		location = "Prefabs/Terrain/Asteroid";
	}

	[UnityTest]
	public IEnumerator TestAsteroidFieldRotatesItself() {

		Quaternion initialRotation = this.prefab.transform.rotation;

		yield return null;
		Assert.AreNotEqual(initialRotation, this.prefab.transform.rotation);
	}

	[Test]
	public void TestAsteroidFieldContainsAsteroids() {
		Assert.Greater(this.prefab.transform.childCount, 0);
	}
}
