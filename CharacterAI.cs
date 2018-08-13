using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour {
	private Actions Anim;


	public Transform startPos, endPos;
	public bool repeatable = false;
	public float speed = 1.0f;
	public float duration = 10.00f;
	public float Rotx;
	public float Roty;
	private DialogueDatabase DD;
	public TextMesh CHAT;
	public string SpeakNow;

	float startTime, totalDistance;

	// Use this for initialization
	//public gameObject Character;

	IEnumerator Start () 
	{
		

		Anim = GetComponent<Actions> ();
		DD = GetComponent<DialogueDatabase> ();
		SpeakNow = "";//DD.Talking [Random.Range(0, DD.Talking.Count)];
		startTime = Time.time;
		totalDistance = Vector3.Distance(startPos.position, endPos.position);
		while(repeatable) {
			yield return LerpForward(startPos.position, endPos.position, duration);
			yield return LerpBack(endPos.position, startPos.position, duration);
		}
	}

	// Update is called once per frame
	void Update () {
		if(!repeatable) {
			float currentDuration = (Time.time - startTime) * speed;
			float journeyFraction = currentDuration / totalDistance;
			this.transform.position = Vector3.Lerp(startPos.position, endPos.position, journeyFraction);
		}

		 //SpeakNow = DD.Words;
		//CHAT.text = SpeakNow;
		//StartCoroutine(Henlo());
		SpeakNow = DD.Words;
		CHAT.text = SpeakNow;
		//StartCoroutine (AnimateText (SpeakNow));
	}

	public IEnumerator LerpForward(Vector3 a, Vector3 b, float time) 
	{
		//this.gameObject.transform.Rotate (0, 0, 0, Space.World);	
		float i = 0.0f;
		float rate = (1.0f / time) * speed;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			this.transform.position = Vector3.Lerp(a, b, i);
			Anim.Walk ();
			yield return null;
		}
	}
	public IEnumerator LerpBack(Vector3 a, Vector3 b, float time) 
	{
		
		float i = 0.0f;
		float rate = (1.0f / time) * speed;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			this.transform.position = Vector3.Lerp(a, b, i);
			Anim.Walk ();
			yield return null;
		}
	}

	void OnTriggerEnter(Collider Other)
	{
		if(Other.gameObject.tag == "StartPos")
		{
			//this.gameObject.transform.Rotate (0, 0, 0, Space.World);
			print ("ROTATE");

			Vector3 temp = transform.rotation.eulerAngles;
			temp.y = Rotx;
			this.gameObject.transform.rotation = Quaternion.Euler(temp);
			
		}
		if(Other.gameObject.tag == "EndPos")
		{
			Vector3 temp = transform.rotation.eulerAngles;
			temp.y = Roty;
			this.gameObject.transform.rotation = Quaternion.Euler(temp);
			//this.gameObject.transform.Rotate (0, 180, 0, Space.World);

		}

	}



}
