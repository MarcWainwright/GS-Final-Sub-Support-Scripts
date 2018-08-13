using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Controller : MonoBehaviour {

	static PlayerController Cont;
	static Actions Animations;


	public float Speed = 0.0f;
	public float MaxSpeed = 1.0f;
	public float Acceleration = 0.1f;
	public float deceleration = 1.0f;

	public GameObject PauseUI;


	//public bool GunOut;


	// Use this for initialization
	void Start () 
	{
		//Speed = 4.00f;
		Animations = GetComponent<Actions> ();

		PauseUI.gameObject.SetActive (false);

		//Speak = GetComponent<GUIText> ();


	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		
		if (Input.GetKey(KeyCode.W) && Speed > -MaxSpeed) {
			if (Speed < 1.0f) {
				Speed = Speed + Acceleration * Time.deltaTime;
			} 
			else 
			{
				Speed = Speed;
			}
			transform.Translate (Vector3.forward * Speed * Time.deltaTime);
			Forward ();

		} 
		if(!Input.GetKey(KeyCode.W)) 
		{
			if (Speed > 0.0f) {
				Speed = Speed - Acceleration * Time.deltaTime;
			} 
			else
			{
				Speed = Speed;
			}
			Animations.Walk ();
			Animations.Stay ();
		}
		if(Input.GetKeyDown(KeyCode.Return))
		{
			Pause ();

		}
		if(Input.GetMouseButton(0) && PauseUI.gameObject.activeInHierarchy == false)
		{
			Animations.Attack ();
		}


	}

	public void Forward()
	{
		transform.Translate (Vector3.forward * Speed * Time.deltaTime);
		Animations.Run ();

	}
	public void Backward()
	{
		transform.Translate (Vector3.back * Speed * Time.deltaTime);
	}

	void Pause()
	{
		if(PauseUI.gameObject.activeInHierarchy == false)
		{
			PauseUI.SetActive (true);
			Time.timeScale = 0;
			Debug.Log ("Paused");
		}
		else
		{
			PauseUI.SetActive (false);
			Time.timeScale = 1;
			Debug.Log ("Unpaused");
		}

	}



}
