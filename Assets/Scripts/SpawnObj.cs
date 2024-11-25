using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject prefabObj;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Obj"))
        {
            Collider[] colls = Physics.OverlapSphere(transform.position, .3f);
            foreach (Collider coll in colls) 
            {
                if (coll.CompareTag("Obj"))
                {
                    return;
                }
            }
            Instantiate(prefabObj, transform.position, transform.rotation);
        }
    }
}
