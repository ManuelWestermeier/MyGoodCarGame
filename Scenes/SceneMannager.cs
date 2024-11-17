using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SceneMannager : MonoBehaviour
{
	public GameObject PausenMenü;
	private float i;
	
	public void LevelUp() 
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		Time.timeScale = 1;
	}
	
	public void LevelDown() 
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
		Time.timeScale = 1;
	}
	
	public void Restart() 
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
		Time.timeScale = 1;
	}
	public void ToMenue() 
	{
		SceneManager.LoadScene("MainMenue");
		Time.timeScale = 1;
	}

	public void ToKampf() 
	{
		SceneManager.LoadScene("Kampf");
		Time.timeScale = 1;
	}
	public void ToPause() 
	{
		PausenMenü.SetActive(true);
		Time.timeScale = 0;
	}
	
	public void Weiter() 
	{
		PausenMenü.SetActive(false);
		Time.timeScale = 1;
	}
}