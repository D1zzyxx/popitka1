using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDestroy : MonoBehaviour
{
    public GameObject particlesDestroy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obj"))
        {
            Destroy(other.gameObject);
            transform.parent.GetComponent<SpawnTargets>().NewTargets();

            Instantiate(particlesDestroy, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
