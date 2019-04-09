using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class fadeout : MonoBehaviour
{
    float fadeoutspeed = 0.01f;//透明度を変えるスピード
    float red, green, blue, alfa;//パネルの色、不透明度を管理
    public static bool isfadeout = false;
    Image fadeimage;//透明度を変更するパネルのイメージ


    // Start is called before the first frame update
    void Start()
    {
        fadeimage = GetComponent<Image>();
        red = fadeimage.color.r;
        green = fadeimage.color.g;
        blue = fadeimage.color.b;
        alfa = fadeimage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey) isfadeout = true;
        if (isfadeout==false) GetComponent<AudioSource>().Play();
        if (isfadeout)
        {
            Startfadeout();
            Invoke("changegame", 2f);
        }

    }

    void Startfadeout()
    {
        
        fadeimage.enabled = true;//パネルの表示をon
        alfa += fadeoutspeed;
        setalfa();
        if (alfa >= 1) isfadeout = false;

    }
    void setalfa()
    {
        fadeimage.color = new Color(red, green, blue, alfa);
    }
    void changegame()
    {
        SceneManager.LoadScene("Game");
    }
}