using UnityEngine;

public class MockInputHandler: IInputHandler {

  private float x;
  private float y;
  private bool xSet;
  private bool ySet;

  public float GetAxis(string s) {
    switch (s) {
      case "Horizontal":
        return xSet ? x : 0;
      case "Vertical":
        return ySet ? y : 0;
      default:
        throw new UnityException("Invalid axis label.");
    }
  }

  public void SetX(float x) {
    this.x = x;
    xSet = true;
  }

  public void UnsetX() {
    xSet = false;
    this.x = 0;
  }

  public void SetY(float y) {
    this.y = y;
    ySet = true;
  }

  public void UnsetY() {
    ySet = false;
    this.y = 0;
  }
}