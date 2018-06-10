using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class MoleController : MonoBehaviour {

    public GameController gameController;
    public MoleSpawner moleSpawner;
    Animator anim;
    private Vector3 mousePosition;
    private int n;
    private int id;

    enum State { Hidden, Up, Hurt };

    State state;

    // Use this for initialization
    void Start () {

        state = State.Hidden;
        anim = GetComponent<Animator>();
        n = 0;
        id = anim.GetInteger("ID");
    }
	
	// Update is called once per frame
	void Update () {

        switch (state)
        {
            case State.Hidden:
                if (moleSpawner.checkUp(id)){
                    state = State.Up;
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
