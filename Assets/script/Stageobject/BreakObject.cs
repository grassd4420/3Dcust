using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObject : MonoBehaviour
{
    // Start is called before the first frame update
  
    private void OnTriggerEnter(Collider col)
    {
        // という名前のタグと接触した場合
        if (col.gameObject.tag == "bk")
        {
            // j壊す
            Destroy(gameObject);
        }
    }
}
