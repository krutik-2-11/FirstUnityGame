
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;		//here we are creating a reference to PlayerMovement script so that when we hit obstacle player movement stops
	void OnCollisionEnter(Collision collisionInfo)		//OnCollisionEnter is a method to check collisions , here we have passed a parameter to check the type of collision
	{
		
		if (collisionInfo.collider.tag == "Obstacles") {	//a tag can be given to similar type of objects so here we have taken Obstacles tag to refer all the obstacles//Debug.Log ("We hit something");
		
			movement.enabled = false;		//this means after hitting obstacle the player stops

			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
