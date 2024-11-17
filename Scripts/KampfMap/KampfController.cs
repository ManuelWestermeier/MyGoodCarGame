using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KampfController : MonoBehaviour
{
    public GameObject Enemy;
    private void Start() {
        if(PlayerPrefs.GetInt("Coins") >= 50) {
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins") - 50);
        } else {
            SceneManager.LoadScene("MainMenue");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("MainMenue");
        }
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins") + 5);
            Instantiate(Enemy, new Vector3(0, 20, 0), Quaternion.identity);;
        }
    }
}
