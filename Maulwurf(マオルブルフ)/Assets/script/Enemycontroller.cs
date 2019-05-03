  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1controller : MonoBehaviour
{
   [SerializeField] private float speed = 0.03f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,this.speed,0);
        if (transform.position.y > 4.0f)  Destroy(gameObject);
    }
}
