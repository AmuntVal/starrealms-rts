
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestAsteroid {
	GameObject asteroid = Resources.Load("Prefabs/Terrain/Asteroid") as GameObject;

	[SetUp]
	public void SetUp() {
		asteroid = Resources.Load<GameObject>("Prefabs/Terrain/Asteroid") as GameObject;
		asteroid = GameObject.Instantiate(asteroid);
	}


	[Test]
	public void TestAsteroidExists() {
		Assert.NotNull(asteroid);
	}

	[UnityTest]
	public IEnumerator TestAsteroidRotatesItself() {

		Quaternion initialRotation = asteroid.transform.rotation;

		yield return null;
		Assert.AreNotEqual(initialRotation, asteroid.transform.rotation);
	}
}
