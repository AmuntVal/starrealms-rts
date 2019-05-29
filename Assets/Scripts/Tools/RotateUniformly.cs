using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUniformly : MonoBehaviour {

	[Range(0,Mathf.Infinity)]
	public float RotationSpeed;
	public Vector3 rotationAngle;

	// Update is called once per frame
	void Update () {
		transform.Rotate(rotationAngle * RotationSpeed * Time.deltaTime);
	}
}
