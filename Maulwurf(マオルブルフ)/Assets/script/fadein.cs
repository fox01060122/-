using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fadein : MonoBehaviour
{
    float fadeinspeed = 0.01f;
    float red, green, blue, alfa;
    bool isfadein = true;
    Image fadeinimage;

    // Start is called before the first frame update
    void Start()
    {
        fadeinimage = GetComponent<Image>();
        red = fadeinimage.color.r;
        green = fadeinimage.color.g;
        blue = fadeinimage.color.b;
        alfa = fadeinimage.color.a;

    }

    // Update is called once per frame
    void Update()
    {
        if(isfadein)
        {
            Startfadein();
        }
    }

    void Startfadein()
    {
        fadeinimage.enabled = true;
        alfa -= fadeinspeed;
        setalfa();
        if (alfa == 0) isfadein = false;
    }
    void setalfa()
    {
        fadeinimage.color = new Color(red, green, blue, alfa);
    }
}
