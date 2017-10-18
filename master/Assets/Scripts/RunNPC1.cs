using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RunNPC1 : MonoBehaviour {

	public enum NPCState { Run, Hit };

	public NPCState npcstate = NPCState.Run;

	private NavMeshAgent nvAgent;
	private Animator animator;
	private bool isDie = false;

	public GameObject Destination;

	public GameObject firstAidSpri1;
	public GameObject firstAidSpri2;

	private void Awake()
	{
		nvAgent = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();
	}

	private void Start()
	{
		StartCoroutine(NPCAction());
	}
	
	IEnumerator NPCAction()
	{
		while (true)
		{
			switch (npcstate)
			{
				case NPCState.Run:
					nvAgent.isStopped = false;
					nvAgent.destination = Destination.transform.position;
					animator.SetBool("isRun", true);
					break;
				case NPCState.Hit:
					nvAgent.isStopped = true;
					animator.SetBool("isRun", false);
					break;
			}
			yield return null;
		}
	}

	public void SetRun()
	{
		if (firstAidSpri1.activeSelf == true)
		{
			firstAidSpri1.SetActive(false);
			Save.instance.SaveFirstAid1 = false;
			Save.instance.SaveNPC1 = true;
			npcstate = NPCState.Run;
		}
		else if(firstAidSpri2.activeSelf == true)
		{
			firstAidSpri2.SetActive(false);
			Save.instance.SaveFirstAid2 = false;
			Save.instance.SaveNPC2 = true;
			npcstate = NPCState.Run;
		}
	}

	public void SetHit()
	{
		npcstate = NPCState.Hit;
	}
}