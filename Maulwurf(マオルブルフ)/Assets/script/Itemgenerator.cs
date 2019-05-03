using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemgenerator : MonoBehaviour
{
    public GameObject enemy1prefab;
    public GameObject enemy2prefab;
    float span = 1.0f;//モグラの生存時間
    int probability = 2;//確率
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta >span)
        {
            delta = 0.0f;
            GameObject item;
            int dice = Random.Range(1, 11);//今のところ20％

            if (dice <= probability) item = Instantiate(enemy2prefab) as GameObject;
            else item = Instantiate(enemy1prefab) as GameObject;

            float x = Random.Range(-8, 10);//今のところ仮のランダム配置
            float z = Random.Range(-2, 5);
            item.transform.position = new Vector3(x, 0, z);
           
        }
    }
}
