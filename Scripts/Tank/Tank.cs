using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tank : MonoBehaviour
{
	public Text TankText;
	public Text CoinText;
	public Text ScoreText;
	public Text HiScoreText;
	public float AktuellesTankVolume;
	public float TankVolume;
	
	private void Start() {
		TankVolume *= PlayerPrefs.GetFloat("TankMultiplicator") + 1;
		AktuellesTankVolume = TankVolume;
		//PlayerPrefs.SetInt("HiScore",0);
	}
	
	private void FixedUpdate() {
		CoinText.text = "Coins : " + (int)PlayerPrefs.GetInt("Coins");
		int pos = (int)transform.position.z;
		ScoreText.text = "Score : " + pos;
		if (pos > PlayerPrefs.GetInt("HiScore"))
		{
			PlayerPrefs.SetInt("HiScore",pos);
		}
		HiScoreText.text = "HighScore : " + PlayerPrefs.GetInt("HiScore");
		TankText.text = "" + (int)AktuellesTankVolume;
		AktuellesTankVolume --;
		
		if (AktuellesTankVolume < 1)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
		}
		
		if (AktuellesTankVolume < 1500)
		{
			TankText.GetComponent<Text>();
			TankText.color= new Color(255,0,0,1);
		}
		else
		{
			TankText.GetComponent<Text>();
			TankText.color= new Color(255,255,255,1);
		}
	}
	
	private void OnTriggerEnter(Collider other) {
		if (other.tag == "Tank")
		{
			AktuellesTankVolume = TankVolume;
		}
	}
}
