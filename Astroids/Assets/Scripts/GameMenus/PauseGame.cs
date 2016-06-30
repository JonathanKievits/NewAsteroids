using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
	public Transform canvas;
	public Transform PauseMenu;
	public Transform OptionsMenu;
    private EnemyMovement[] enemyMovement;


    void Start()
    {
        enemyMovement = GameObject.FindObjectsOfType<EnemyMovement>();
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Pause ();
		} 
			
	}
	public void Pause()
	{
		if (canvas.gameObject.activeInHierarchy == false) 
		{
			if (PauseMenu.gameObject.activeInHierarchy == false) 
			{
				PauseMenu.gameObject.SetActive (true);
				OptionsMenu.gameObject.SetActive(false);
			}
		}

		if (canvas.gameObject.activeInHierarchy == false) 
		{
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;

            foreach (EnemyMovement e in enemyMovement)
            {
                e.gameObject.SetActive(false);
            }
            
			//Player.GetComponent<CameraFollow> ().enabled = false;
		} else 
		{
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
            foreach (EnemyMovement e in enemyMovement)
            {
                e.gameObject.SetActive(true);
            }
            //Player.GetComponent<CameraFollow> ().enabled = true;
        }
	}
  
	public void optionsMenu(bool Open)
	{
		if (Open)
		{
			OptionsMenu.gameObject.SetActive (true);
			PauseMenu.gameObject.SetActive (false);
		}

		if (!Open) 
		{
			OptionsMenu.gameObject.SetActive (false);
			PauseMenu.gameObject.SetActive (true);
		}
	}

	public void Exit()
	{
		Application.LoadLevel (0);
        Time.timeScale = 1;
    }
		

}
