using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas instructionMenu;
	public Canvas OptionsMenu;
	public Button startText;
	public Button instructionText;
	public Button exitText;
	public Button OptionsText;

	// Use this for initialization
	void Start () 
	{
		quitMenu = quitMenu.GetComponent<Canvas> ();
		instructionMenu = instructionMenu.GetComponent<Canvas> ();
		OptionsMenu = OptionsMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		instructionText = instructionText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		OptionsText = OptionsText.GetComponent<Button> ();
		quitMenu.enabled = false;
		instructionMenu.enabled = false; 
		OptionsMenu.enabled = false;
	}
	
	public void ExitPress()
	{
		quitMenu.enabled = true;
		instructionMenu.enabled = false;
		OptionsMenu.enabled = false;
		startText.enabled = false;
		instructionText.enabled = false;
		exitText.enabled = false;
		OptionsText.enabled = false;

	}

	public void NoPress()
	{
		quitMenu.enabled = false;
		instructionMenu.enabled = false;
		OptionsMenu.enabled = false;
		startText.enabled = true;
		instructionText.enabled = true;
		exitText.enabled = true;
		OptionsText.enabled = true;
	}

	public void Instructions()
	{
		quitMenu.enabled = false;
		instructionMenu.enabled = true;
		OptionsMenu.enabled = false;
		startText.enabled = false;
		instructionText.enabled = false;
		exitText.enabled = false;
		OptionsText.enabled = false;
	}

	public void GoBack()
	{
		quitMenu.enabled = false;
		instructionMenu.enabled = false;
		OptionsMenu.enabled = false;
		startText.enabled = true;
		instructionText.enabled = true;
		exitText.enabled = true;
		OptionsText.enabled = true;
	}

	public void Options()
	{
		quitMenu.enabled = false;
		instructionMenu.enabled = false;
		OptionsMenu.enabled = true;
		startText.enabled = false;
		instructionText.enabled = false;
		exitText.enabled = false;
		OptionsText.enabled = false;
	}

	public void StartLevel()
	{
		Application.LoadLevel (1);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
