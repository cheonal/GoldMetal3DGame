using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRock : Bullet
{
    Rigidbody rigid;
    float angularpower = 2;
    float scalevalue = 0.1f;
    bool isShoot;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(GainPowerTimer());
        StartCoroutine(GainPower());




    }
    IEnumerator GainPowerTimer()
    {
        yield return new WaitForSeconds(2.2f);
        isShoot = true;
    }

    IEnumerator GainPower()
    {
        while (!isShoot)
        {
            angularpower += 0.1f;
            scalevalue += 0.005f;
            transform.localScale = Vector3.one * scalevalue;
            rigid.AddTorque(transform.right * angularpower, ForceMode.Acceleration);
            yield return null;
        }
    }


}
