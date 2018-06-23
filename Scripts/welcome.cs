using UnityEngine.SceneManagement;
using UnityEngine;

public class welcome : MonoBehaviour {
	
	public void StartGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
