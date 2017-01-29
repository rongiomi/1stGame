using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitsToKill : MonoBehaviour
{

    public float HP;
    //public GameObject go;
   // public GameObject bullet;

    public void OnCollisionEnter2D(Collision2D col) {
        print(HP);
        Health();
       // if (col.gameObject.tag == "NPC") {
        //Destroy(gameObject);
        HP -= 1;
       //}

    }

    void Health() {
        print("HEALTH METHOD " + HP);
        if (HP <= 0) {
            Destroy(gameObject);
        }
    }


}