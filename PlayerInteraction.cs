using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {



	 static Actions Do;
	public bool DoIt;
	private CharacterAI CAI;
	static GameObject Weapon;
	private GameManager GA;
	public int DeathCount;
	// Use this for initialization
	void Start () 
	{

		GA = FindObjectOfType<GameManager> ();
		DeathCount = 9;
		//Destroy (this.gameObject);
		CAI = GetComponent<CharacterAI>();
		DoIt = true;
		//con = FindObjectOfType<Controller> ();

		//Threat = FindObjectOfType<GunCheck> ();
		//Threat =  GetComponent<GunCheck>();
		Do = FindObjectOfType<Actions> ();
		//Do = GetComponent<Actions>();


//		Weapon = GameObject.FindGameObjectWithTag ("Gun");

	}

	void Update()
	{

//		if(Input.GetMouseButtonDown(0))
//		{
//			Destroy (this.gameObject);
//
//		}

		Weapon = GameObject.FindGameObjectWithTag ("Gun");
		print (DeathCount);

	}

	void OnMouseDown()
	{
		//Destroy (this.gameObject);

		if (Input.GetMouseButtonDown(0)|| Input.GetMouseButtonDown(1))
			
		{
//			print ("DIIIIIE");
//			Destroy (this.gameObject);
			if(Weapon.gameObject.activeInHierarchy == true)
			{ 
//				print ("DIIIIIE");
//				Destroy (gameObject);
				Death();

				print (DeathCount);
			}
			
		}
	}
	public void Death()
	{

		print ("DIIIIIE");
		Destroy (gameObject);
		//gameObject.SetActive(false);
		DeathCount += -1;

	}

}
