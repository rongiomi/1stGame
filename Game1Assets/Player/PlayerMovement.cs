using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// might not need

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public Rigidbody2D rb2d;
    public int JumpNumber = +10;
    public AnimationState MovingPM;
    public Vector2 Jump = new Vector2(0, +10);
    public GameObject go;

    Animator anim;

    public void Update() {
        anim = GetComponent<Animator>();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos);

        if (Input.GetKeyDown(KeyCode.A) == true) {
            Vector2 moveXN = new Vector2(-10,0);
            anim.SetBool("MovePM",true);
            rb2d.velocity = new Vector2(-10, 0);
        } else if (Input.GetKeyDown(KeyCode.D) == true) {
            Vector2 moveXN = new Vector2(10, 0);
            anim.SetBool("MovePM", true);
            rb2d.velocity = new Vector2(10, 0);
        } else {
            anim.SetBool("MovePM",false);
        }

        if (Input.GetKeyUp(KeyCode.Space)){
            Vector2 Jump;
            rb2d.velocity = new Vector2(0, +5 * JumpNumber);
        }

       // rb2d.velocity = new Vector2(moveXN,0);
    }
}
