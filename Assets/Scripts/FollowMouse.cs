using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

    private Vector3 mousePosition;
    public float moveSpeed = 100f;
    Animator anim;
    public GameController gameController;

    
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        if (Input.GetMouseButtonDown(0))
        {

            anim.SetTrigger("HammerHit");
            
        }
        
    }
}
