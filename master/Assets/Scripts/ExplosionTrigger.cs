using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour {

	public GameObject Exp;
	public GameObject Smoke;
	public GameObject Fire;

	private RunNPC1 run1;
	private RunNPC1 run2;

	private void Awake()
	{
		run1 = GameObject.Find("Girl008").GetComponent<RunNPC1>();
		run2 = GameObject.Find("Man006").GetComponent<RunNPC1>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("NPC1"))
		{
			run1.SetHit();
			run2.SetHit();
			Exp.SetActive(true);
			Destroy(gameObject, 2.0f);
			Destroy(Exp, 5.0f);
			Smoke.SetActive(false);
			Fire.SetActive(true);
			InvokeRepeating("FireParticleIncrease", 1.0f, 0.1f);
		}
	}

	private void FireParticleIncrease()
	{
		Fire.GetComponent<ParticleSystem>().maxParticles += 3;
	}
}
