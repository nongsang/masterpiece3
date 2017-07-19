using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC1 : MonoBehaviour {

    public Transform target1, target2, target3;
    private NavMeshAgent nav;
    int goTargetNum = 1;
    Animator ani;

	bool on = false;

	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
        nav.SetDestination(target1.position);
        ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(goTargetNum == 1)
        {
            if((transform.position.x == target1.position.x) && (transform.position.z == target1.position.z))
            {
                setDesTarget2();
            }
        }
        else if(goTargetNum == 2)
        {
            if ((transform.position.x == target2.position.x) && (transform.position.z == target2.position.z))
            {
                setDesTarget1();
            }
        }
        if (on)
        {
            ani.Play("standard_run");
            setDesTarget3();
            nav.speed = 5;
        }
	}

    void setDesTarget1()
    {
        nav.SetDestination(target1.position);
        goTargetNum = 1;
    }

    void setDesTarget2()
    {
        nav.SetDestination(target2.position);
        goTargetNum = 2;
    }

    void setDesTarget3()
    {
        nav.SetDestination(target3.position);
    }
    public GameObject getGameObject()
    {
        return gameObject;
    }

	void Switch()
	{
		on = true;
	}
}
