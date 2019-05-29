
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public abstract class PrefabTest {

  protected string location = "";
	protected GameObject prefab;

	[SetUp]
	public virtual void SetUp() {
		prefab = Resources.Load<GameObject>(location) as GameObject;
		prefab = GameObject.Instantiate(prefab);
	}

	[Test]
	public void TestPrefabExists() {
		Assert.NotNull(prefab);
	}

}
