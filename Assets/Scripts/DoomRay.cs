using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomRay : MonoBehaviour
{
    private Vector3 target;
    [SerializeField] GameObject explosion;
    public void SetTarget(Vector3 targ)
    {
        target = targ;
    }
    private void Update()
    {
        Debug.Log("hi");
        if(transform.position == target)
        {
            Debug.Log("bang");
            Instantiate(explosion, transform.position, Quaternion.identity);
            GetComponent<DoomRay>().enabled = false;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);
    }
}
