using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	public bool isColliding = false;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Ground")
		{
			isColliding = true;
		}
	}


	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Ground")
		{
			isColliding = false;
		}
	}
}