using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGearAnim : MonoBehaviour
{
    public int direction = 1;
    public float speed = 2f;

    void Update()
    {
        transform.Rotate(0, speed * direction, 0);
    }
}
