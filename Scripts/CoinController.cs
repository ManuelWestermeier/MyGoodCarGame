using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins") + 10);
        }
    }
}
