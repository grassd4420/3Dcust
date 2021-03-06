using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//転がって来る障害物の生成処理


public class CsGenerator : MonoBehaviour
{

    public GameObject CsPrefab;
    float span = 5.0f;　//生成間隔
    float delta = 0;
    public Vector3 pos;
    public int x, y;　//生成座標の最大と最小値

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(CsPrefab) as GameObject;
            int px = Random.Range(x,y);
            go.transform.position = new Vector3(pos.x, pos.y, px);
        }
    }
}
