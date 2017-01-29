using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D coll)
    {
        print("destroyed");
        Destroy(gameObject);
    }
}
