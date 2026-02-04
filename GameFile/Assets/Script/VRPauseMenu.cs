using UnityEngine;

public class VRPauseMenu : MonoBehaviour
{
	public GameObject pauseMenu;
	private bool isPaused = false;

	public void TogglePause()
	{
		isPaused = !isPaused;
		pauseMenu.SetActive(isPaused);
		Time.timeScale = isPaused ? 0f : 1f;
	}

	public void Resume()
	{
		isPaused = false;
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
	}
}

public Transform headset;

void ShowMenu()
{
	pauseMenu.transform.position =
		headset.position + headset.forward * 1.5f;
	pauseMenu.transform.rotation =
		Quaternion.LookRotation(pauseMenu.transform.position - headset.position);
}
