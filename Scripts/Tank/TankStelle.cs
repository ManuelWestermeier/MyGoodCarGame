using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStelle : MonoBehaviour
{
	public GameObject a;
	private void OnTriggerEnter(Collider other) {
	if (other.tag == "Player")
		{
			Destroy(a);
		}
	}
}
