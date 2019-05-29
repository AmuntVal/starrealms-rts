using UnityEngine;
using UnityEngine.TestTools;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;


public class TestShip : PrefabTest {

	Ship ship;
	MockInputHandler mockInputHandler;

	public TestShip() {
		this.location = "Prefabs/Ships/Ship";
	}

	[SetUp]
	public override void SetUp() {
		base.SetUp();
		ship = prefab.GetComponent<Ship>();
		// Mock the ship's input handler.
		mockInputHandler = new MockInputHandler();
		ship.InputHandler = mockInputHandler;
	}

	[UnityTest]
	public IEnumerator TestShipDoesntMoveOnNoInput() {
		Vector3 initialPosition = prefab.transform.position;
		yield return null;
		Vector3 currentPosition = prefab.transform.position;
		Assert.AreEqual(initialPosition, currentPosition);
	}

	[UnityTest]
	public IEnumerator TestShipMovesForwardOnInputUp() {
		mockInputHandler.SetY(4);
		Vector3 initialPosition = prefab.transform.position;
		yield return null;
		Vector3 currentPosition = prefab.transform.position;
		Assert.AreEqual((currentPosition - initialPosition).normalized, prefab.transform.forward);
	}

	[UnityTest]
	public IEnumerator TestShipMovesBackwardOnInputDown() {
		mockInputHandler.SetY(-4);
		Vector3 initialPosition = prefab.transform.position;
		yield return null;
		Vector3 currentPosition = prefab.transform.position;
		Assert.AreEqual((currentPosition - initialPosition).normalized, -prefab.transform.forward);
	}

	[UnityTest]
	public IEnumerator TestShipRotatesLeftOnInputLeft() {
		mockInputHandler.SetX(-4);
		Vector3 originalForward = prefab.transform.forward;
		yield return null;
		Vector3 currentForward = prefab.transform.forward;
		// euler angles are between 0 and 360.
		Assert.Greater(Quaternion.FromToRotation(originalForward, currentForward).eulerAngles.y, 180);
	}

	[UnityTest]
	public IEnumerator TestShipRotatesRightOnInputRight() {
		mockInputHandler.SetX(4);
		Vector3 originalForward = prefab.transform.forward;
		yield return null;
		Vector3 currentForward = prefab.transform.forward;
		// euler angles are between 0 and 360.
		Assert.Less(Quaternion.FromToRotation(originalForward, currentForward).eulerAngles.y, 180);
	}
}
