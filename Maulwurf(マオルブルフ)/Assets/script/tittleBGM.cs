using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tittleBGM : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeout.isfadeout)GetComponent<AudioSource>().Stop();
        
    }
}
