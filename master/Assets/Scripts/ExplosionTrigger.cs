using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour {

	public GameObject Exp;
	public GameObject Smoke;
	public GameObject Fire;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
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
