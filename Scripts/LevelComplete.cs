using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public void LoadNextLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);		//this loads the next scene present just after the current scene
	}

}
