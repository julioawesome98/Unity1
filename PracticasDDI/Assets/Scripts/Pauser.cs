using UnityEngine;
using System.Collections;
using UnityEngine.Scene;
public class Pauser : MonoBehaviour {
	private bool paused = false;
    public GameObject pausePanel;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.P))
		{
			paused = !paused;
            pausePanel.SetActive(paused);
		}

		if(paused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}
    public void ContinueGame()
    {
        Debug.Log("Continuaar...");
        paused = false;
        pausePanel.SetActive(paused);
    }
    public void ResetGame()
    {
        Debug.Log("Continuaar");
        SceneManager.LoadScene(0);
    }
    public void MuteMusic()
    {
        Debug.Log("Continuaar");
    }
}
