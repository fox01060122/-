using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class hunmer : MonoBehaviour
{

    private Ray Hummer;
    private RaycastHit Enemyhit; //オブジェクトの情報取得変数
    private GameObject SelectedObject;//ここにエネミーの情報を入れる
    private Animator animator;
    [SerializeField] private GameObject Object;


    private void Start()
    {
        animator = GetComponent<Animator>();
      
    }


    // Update is called once per frame
    void Update()
    {       
       

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 5, z);
            }
            hunmeratt();
            SearchRoom();
        }
    }

    void hunmeratt()
    {
        animator.SetTrigger("on");
    }

    void SearchRoom()
    {
        SelectedObject = null; //空にしておく
        Hummer = Camera.main.ScreenPointToRay(Input.mousePosition);//メインカメラ上のマウスカーソルのある位置からRayを飛ばす
        if (Physics.Raycast(Hummer, out Enemyhit, Mathf.Infinity, 1 << 10))//発射位置マウスカーソル
        {
            SelectedObject = Enemyhit.collider.gameObject;
            switch(SelectedObject.name)
            {
                case "enemy1"://オブジェクトの名前
                    Destroy(SelectedObject);
                    break;
                case "enemy2":
                    Destroy(SelectedObject);
                    break;
            }
        }
     }
}
