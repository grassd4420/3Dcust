using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//転がって来る障害物の当たり判定の処理

public class CircleObjectColliderSwitcher : MonoBehaviour
{
    private DimentionSwitcher switcher;

    // Start is called before the first frame update
    void Start()
    {
        switcher = FindObjectOfType<DimentionSwitcher>();
    }

    //3d空間内でのColliderを所得
    private void Get3dCollider()
    {
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<MeshCollider>().enabled = true;
    }

    //２d空間内でのColliderを所得
    private void Get2dCollider()
    {
        GetComponent<CapsuleCollider>().enabled = true;
        GetComponent<MeshCollider>().enabled = false;
        CapsuleCollider collider = GetComponent<CapsuleCollider>();
        collider.height = 60;
    }
    

    // Update is called once per frame
    void Update()
    {
        //空間に応じて切り替え

        //3ｄ時
        if(switcher.vi )
        {
            Get3dCollider();
        }

        //２ｄ時
        if (switcher.vi == false)
        {
            Get2dCollider();
        }
    }
}
