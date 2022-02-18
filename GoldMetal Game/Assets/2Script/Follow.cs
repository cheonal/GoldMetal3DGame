using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public Transform target;


    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;

    }
}
