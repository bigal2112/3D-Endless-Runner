using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
  public int rotateSpeed = 4;

  void Update()
  {
    transform.Rotate(0, rotateSpeed, 0, Space.World);
  }
}
