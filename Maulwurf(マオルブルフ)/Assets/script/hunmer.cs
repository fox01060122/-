using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunmer : MonoBehaviour
{
    [SerializeField] private GameObject hun = null;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 touchpoint = Input.mousePosition;

        touchpoint.x = Mathf.Clamp(touchpoint.x, 0.0f, Screen.width);
        touchpoint.y = Mathf.Clamp(touchpoint.y, 0.0f, Screen.height);

        Camera gamecamera = Camera.main;
        Ray touchpointToray = gamecamera.ScreenPointToRay(touchpoint);

        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(touchpointToray, out hit))//原点,飛ばす方向,衝突した情報,長さ
            hun.transform.position = hit.point;

        if(Input.GetMouseButtonDown(1))
        {
            hunmeratt();
        }
    }

    void hunmeratt()
    {
        animator.SetTrigger("on");
    }

}
