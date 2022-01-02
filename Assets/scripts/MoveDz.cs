using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDz : MonoBehaviour
{
    public float speed = 2;
    void Start()
    {
    }
    public void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
