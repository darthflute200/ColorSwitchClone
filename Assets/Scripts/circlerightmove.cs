using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlerightmove : MonoBehaviour
{


    private float speed = 50f;


    void Update()
    {
        transform.Rotate(0f, 0f, -1 * speed * Time.deltaTime);

    }
}
