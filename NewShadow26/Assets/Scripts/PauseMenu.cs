using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	public GameObject pauseMenu;
	public bool paused = false;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (Time.timeScale == 1) { Time.timeScale = 0; showPaused(); }
			else if (Time.timeScale == 0) { Time.timeScale = 1; hidePaused(); paused = false; }
		}
	}

	public void showPaused()
	{
		pauseMenu.SetActive(true);
		paused = true;
	}
	public void hidePaused()
	{
		pauseMenu.SetActive(false);
		paused = false;
	}

}
