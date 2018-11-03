using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour
{
    int blowpoint = 1;
    public float Speed;
    public int Maxforward;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Blow")
        {
            blowpoint += 1;
        }

    }

    private void FixedUpdate()
    {
        if (blowpoint > 0 && Input.GetKey(KeyCode.W) && (transform.position.z < Maxforward))
        {
            transform.Translate(Vector3.left * Speed);
            blowpoint -= 1;
        }
    }


}
