using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class MoleController : MonoBehaviour {

    public GameController gameController;
    Animator anim;
    private Vector3 mousePosition;
    private int n;

    enum State { Hidden, Up, Hurt };

    State state;

    // Use this for initialization
    void Start () {

        state = State.Hidden;
        anim = GetComponent<Animator>();
        n = 0;
    }
	
	// Update is called once per frame
	void Update () {

        switch (state)
        {
            case State.Hidden:
                System.Random rnd = new System.Random();
                int rnum = rnd.Next(0, 100);
                n++;
                if(rnum == 19 & n%10 == 0){
                    state = State.Up;
                    anim.SetTrigger("MolePopUp");
                }
                break;
            case State.Up:
                
                break;
            case State.Hurt:
                n++;
                if (n > 100)
                {
                    state = State.Hidden;
                    n = 0;
                }
                    
                break;
        }


        


	}

    void OnMouseDown()
    {
        if(state == State.Up){
            n = 0;
            state = State.Hurt;
            anim.SetTrigger("MoleHit");
        }
        
    }

}
