using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    public float aniTime = 10f;

    void Update()
    {
        Destroy(gameObject, aniTime);
    }
}
