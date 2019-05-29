
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestAsteroidField {
	GameObject asteroidField = Resources.Load("Prefabs/Terrain/AsteroidField") as GameObject;

	[SetUp]
	public void SetUp() {
		asteroidField = Resources.Load<GameObject>("Prefabs/Terrain/AsteroidField") as GameObject;
		asteroidField = GameObject.Instantiate(asteroidField);
	}

	[UnityTest]
	public IEnumerator TestAsteroidRotatesItself() {

		Quaternion initialRotation = asteroidField.transform.rotation;

		yield return null;
		Assert.AreNotEqual(initialRotation, asteroidField.transform.rotation);
	}

	[Test]
	public void TestAsteroidFieldContainsAsteroids() {
		Assert.Greater(asteroidField.transform.childCount, 0);
	}
}
