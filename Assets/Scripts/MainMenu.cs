using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  
	public void PlayGame()
	{
		SceneManager.LoadScene("Runner");
	}

	public void ExitGame()
	{
		Debug.Log("Quit!");
		Application.Quit();

	}





}
