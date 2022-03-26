using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.up * 12 * Time.deltaTime);
    }
}
