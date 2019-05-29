
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestAsteroid: PrefabTest {

	public TestAsteroid() {
		location = "Prefabs/Terrain/Asteroid";
	}

	[UnityTest]
	public IEnumerator TestAsteroidRotatesItself() {

		Quaternion initialRotation = this.prefab.transform.rotation;

		yield return null;
		Assert.AreNotEqual(initialRotation, this.prefab.transform.rotation);
	}
}
