using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarMenue : MonoBehaviour
{
    public UpgrateController UC;
    public Text CoinText;
    public Text TankUpText;
    //public List<Texture> textures;

    private void Start()
    {
        CoinText.text = "Coins : " + PlayerPrefs.GetInt("Coins");
        TankUpText.text = "Upgrade Tank : " + (int)(10 * (PlayerPrefs.GetFloat("TankMultiplicator") + 1)) + "$";
        if (PlayerPrefs.GetInt("Coins") > (10 * (PlayerPrefs.GetFloat("TankMultiplicator") + 1)) || PlayerPrefs.GetInt("Coins") == (10 * (PlayerPrefs.GetFloat("TankMultiplicator") + 1)))
        {
            TankUpText = TankUpText.gameObject.GetComponent<Text>();
            TankUpText.color = new Color(0, 255, 0, 1);
        }
        else
        {
            TankUpText = TankUpText.gameObject.GetComponent<Text>();
            TankUpText.color = new Color(255, 0, 0, 1);
        }
    }

    public void TankUp()
    {
        if (PlayerPrefs.GetInt("Coins") > (10 * (PlayerPrefs.GetFloat("TankMultiplicator") + 1)) || PlayerPrefs.GetInt("Coins") == (10 * (PlayerPrefs.GetFloat("TankMultiplicator") + 1)))
        {
            PlayerPrefs.SetFloat("TankMultiplicator", PlayerPrefs.GetFloat("TankMultiplicator") + 0.1f);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - (int)(10 * (PlayerPrefs.GetFloat("TankMultiplicator") + 1)));
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void NextCar(int index)
    {
        PlayerPrefs.SetInt("PlayerColor", index);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
