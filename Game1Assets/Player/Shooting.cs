using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public Rigidbody2D projectile;
    //public GameObject go;
    public float speed = 20;




    void Update() {

        if (Input.GetKeyDown(KeyCode.E)){
            Rigidbody2D instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector2(+speed, 0));
            
        }
     
    }


}
