
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;	//this is reference for rigidbody component

	public float forwardForce = 100f;
	public float sideWaysForce = 500f;

	// Use this for initialization
	void Start () {
		//rb.AddForce(0,500,5000);
	}
	
	// Update is called once per frame

	//There is a problem that every computer has a variable frame rate depending on its processing speed
	//so to even out this problem we use Time.deltaTime to even the adjustment of frame rate
	//that means if frame rate is high Time.deltaTime will be low and vice versa
	void Update () {
		rb.AddForce(0,0,forwardForce*Time.deltaTime);

		if (Input.GetKey ("d")) 
		{
			rb.AddForce (sideWaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}

		if (Input.GetKey ("a")) 
		{
			rb.AddForce (-sideWaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}

		if (rb.position.y < -6f)
		{
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
