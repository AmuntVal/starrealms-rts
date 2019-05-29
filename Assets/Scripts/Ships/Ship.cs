using UnityEngine;

public class Ship: MonoBehaviour {
  public IInputHandler InputHandler = new ArrowKeyInputHandler();

  public float MoveSpeed;
  public float RotateSpeed;

  void Update() {
    transform.Translate(Vector3.forward * InputHandler.GetAxis("Vertical") * MoveSpeed * Time.deltaTime, Space.Self);
    transform.Rotate(0, InputHandler.GetAxis("Horizontal") * RotateSpeed * Time.deltaTime, 0);
  }
}
