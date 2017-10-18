using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour {

	public GameObject invisableWall;
	public GameObject[] Fires;
	public GameObject[] Exp;

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			invisableWall.SetActive(true);
			foreach (GameObject fire in Fires)
			{
				fire.SetActive(true);
			}
			foreach (GameObject exp in Exp)
			{
				exp.SetActive(true);
			}
		}
	}
}
