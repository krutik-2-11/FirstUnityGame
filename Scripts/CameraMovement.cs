
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Transform player;		//This is used to get position of player

	public Vector3 offset; 			//vector3 is not a data type but it stores 3 float variables, vector2 stores 2 and similarly vector4 stores 4

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(player.position);	//This line gives the position of player in console

		transform.position = player.position + offset;		//here transform with small t refers to current object , here it is refering to transform(position) of camera

		//however the above command will make camera inside the player thus making a first person view


	}
}
