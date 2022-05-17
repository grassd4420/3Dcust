using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObject : MonoBehaviour
{
    private const string BreakObjectTag = "bk";

    private void OnTriggerEnter(Collider col)
    {
        // という名前のタグと接触した場合
        if (col.CompareTag(BreakObjectTag))
        {
            // j壊す
            Destroy(gameObject);
        }
    }
}
