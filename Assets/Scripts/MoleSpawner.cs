using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour {

    Dictionary<int, bool> moles = new Dictionary<int, bool>();
    int numMolesUp = 0;
    int n = 0;
    int minMoles = 2;

	// Use this for initialization
	void Start () {
        addMoles(4);
	}
	
	// Update is called once per frame
	void Update () {
		if (n%10 == 0 && numMolesUp < minMoles){
            System.Random rnd = new System.Random();
            int rnum = rnd.Next(0, 100);
            if(rnum == 3)
            {
                rnum = rnd.Next(0, 4);
                moles[rnum] = true;
            }
        }
	}


    void addMoles(int numMoles)
    {
        for(int i = 0; i < numMoles; i++)
        {
            moles.Add(i, false);
        }
    }


    public bool checkUp(int moleId)
    {
        return moles[moleId];
    }

    public void retract(int moleId)
    {
        moles[moleId] = false;
    }
}
