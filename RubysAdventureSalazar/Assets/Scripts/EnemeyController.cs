using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyController : MonoBehaviour
{
    public float speed;

    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponet<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
