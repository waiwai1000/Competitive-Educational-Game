using UnityEngine;

public class ScienceMenuScreenController : MonoBehaviour
{
	public void StartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("ScienceGame");
	}
    public void MainMenuPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Map");
    }
}