using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerControls : MonoBehaviour {

    public float maxSpeed = 10f;
    public bool directionRight = false ;
    public Rigidbody2D deer;
    public Animator anim;

	// Use this for initialization
	void Start () {
		deer = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	// In sync with animator
	void FixedUpdate () {
        float move = Input.GetAxis("Horizontal");

        //mantains its y velocity, but the x velocity is any number (pos or neg) up to the max speed
        deer.velocity = new Vector2(move * maxSpeed, deer.velocity.y);

        anim.SetFloat("Speed", Mathf.Abs(move));
        
        //if the direction of velocity has changed then we need to do a flip
        if(move < 0 && directionRight){
            Debug.Log("flip left");
            Flip();
        }
        else if(move > 0 && !directionRight){
            Debug.Log("flip right");
            Flip();
        }

	}

    void Flip ()
    {
        directionRight = !directionRight;
        anim.SetBool("Right", directionRight);
    }
}
