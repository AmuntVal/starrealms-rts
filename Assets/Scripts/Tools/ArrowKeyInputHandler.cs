using UnityEngine;

public class ArrowKeyInputHandler: IInputHandler {

  public float GetAxis(string axis) {
    if(axis == "Vertical") {
      if(Input.GetKey(KeyCode.UpArrow) ^ Input.GetKey(KeyCode.DownArrow)) {
        if(Input.GetKey(KeyCode.UpArrow)) {
          return 1;
        }
        //Down arrow has been pressed.
        return -1;
      }
      return 0;
    }
    if(axis == "Horizontal") {
      if(Input.GetKey(KeyCode.LeftArrow) ^ Input.GetKey(KeyCode.RightArrow)) {
        if(Input.GetKey(KeyCode.RightArrow)) {
          return 1;
        }
        //Left arrow has been pressed.
        return -1;
      }
      return 0;
    }
    throw new UnityException("Invalid axis.");
  }


}
