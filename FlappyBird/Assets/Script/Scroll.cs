using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{

    public float ScrollSpeed = 0.5f;
    float Target_offset;

    void Update()
    {
        Target_offset += Time.deltaTime * ScrollSpeed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Target_offset, 0);
    }
}
