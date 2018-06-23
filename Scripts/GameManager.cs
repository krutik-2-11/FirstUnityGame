
using UnityEngine;
using UnityEngine.SceneManagement;			//used to shift between the scenes or reload the scenes

public class GameManager : MonoBehaviour {

	public bool isGameOver = false;
	public float restartDelay = 1f;
	public GameObject completeLevelUI;
	public void CompleteLevel()
	{
		completeLevelUI.SetActive (true);
		Debug.Log ("Level Complete");
	}
	public void EndGame()
	{
		if (isGameOver == false) 
		{
			isGameOver = true;
			Debug.Log ("Game Over");
			//Restart ();	//Restart method restarts the game very quickly so we'll use invoke method

			Invoke ("Restart",restartDelay);
		}

	}

	void Restart()
	{
		//SceneManager.LoadScene ("Scene1");	//This statement is not used because it is not always the Scene1 that we load
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);		//this loads the present scene
	}
}
