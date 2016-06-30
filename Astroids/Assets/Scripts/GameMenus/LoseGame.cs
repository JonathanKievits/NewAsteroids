using UnityEngine;
using System.Collections;

public class LoseGame : MonoBehaviour {

	public Transform canvas;
	public Transform LoseScreen;

		
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.I)) 
		{
			Lose ();
		} 
	}
	public void Lose()
	{
		if (canvas.gameObject.activeInHierarchy == false) 
		{
			if (LoseScreen.gameObject.activeInHierarchy == false)
			{
				LoseScreen.gameObject.SetActive (true);
			}
		}
		if (canvas.gameObject.activeInHierarchy == false) 
		{
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
			//Player.GetComponent<CameraFollow> ().enabled = false;
		} else 
		{
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			//Player.GetComponent<CameraFollow> ().enabled = true;
		}
	}

	public void Retry()
	{
		Application.LoadLevel (1);
		Time.timeScale = 1;
	}

	public void Quit()
	{
		Application.LoadLevel (0);
		Time.timeScale = 1;
	}
}
