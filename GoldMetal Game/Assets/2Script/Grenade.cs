using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject meshobj;
    public GameObject effectobj;
    public Rigidbody rigid;
    void Start()
    {
        StartCoroutine(Explosion());
    }



    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(3f);
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        meshobj.SetActive(false);
        effectobj.SetActive(true);

        RaycastHit[] rayHits =
            Physics.SphereCastAll(transform.position, 15, Vector3.up, 0, LayerMask.GetMask("Enemy"));


        foreach (RaycastHit hitobj in rayHits)
        {
            hitobj.transform.GetComponent<Enemy>().HitByGrenade(transform.position);
        }

        Destroy(gameObject, 5);

    }
}
