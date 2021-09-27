using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(transform.position.y - 0.02f,
                transform.position.x);

        if (transform.position.x < -9.8f)
        {
            Destroy(this.gameObject);
        }
    }
}