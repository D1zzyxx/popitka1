using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    public GameObject perfabTargets;

    public void NewTargets()
    {
        StartCoroutine(DelayCreate());
    }
    private IEnumerator DelayCreate()
    {
        yield return new WaitForSeconds(2f);
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-1f, 1f);
        float z = Random.Range(-1f, 3f);

        Vector3 newPos = new Vector3(x, y, z);
        Transform currentTarget = Instantiate(perfabTargets, transform.position + newPos, transform.rotation).transform;
        currentTarget.parent = transform;
    }
}
