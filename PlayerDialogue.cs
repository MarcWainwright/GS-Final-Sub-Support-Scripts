using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogue : MonoBehaviour {

	public TextMesh speech;
	public string str;
	public int i;
	public string CurrentlySpeaking;
	string OpeningSpeech;
	string FollowUpOpening;
	int TextAnimSpeed = 2;
	public bool CoroFin;
	static DialogueDatabase Dialogue;
	private int SpeakCounter;
	bool finishedspeaking;
	// Use this for initialization
	void Start () 
	{
		finishedspeaking = false;
		CoroFin = false;
		str = "";
		SpeakCounter = 0;
		OpeningSpeech = "And they must turn from evil and do good; \n They must seek peace and pursue it";
		FollowUpOpening = "Now go my children of god \n Go in peace...";
		Dialogue = FindObjectOfType<DialogueDatabase> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		TalkManagement ();
		print (CoroFin);
		print(SpeakCounter);
		if(finishedspeaking == true)
		{
			speech.text = Dialogue.Words;
		}
	}

	public void TalkManagement()
	{
		switch (SpeakCounter) 
		{
		case 0:
			StartCoroutine (AnimateText (OpeningSpeech));
			if(CoroFin == true){
				StopAllCoroutines ();
				SpeakCounter = 1;
			}
			break;
		case 1:
			print ("Clear");
			speech.text = "";
			StartCoroutine (AnimateText (FollowUpOpening));
			StartCoroutine (clear());
			break;

		}


	}


	IEnumerator AnimateText(string strComplete)
	{
		
		CurrentlySpeaking = strComplete;
		i = 0;
		str = "";
//		CurrentlySpeaking = OpeningSpeech;
		while (i < strComplete.Length)
		{
			str += strComplete [i++];
			yield return new WaitForSeconds (0.5f / TextAnimSpeed * Time.deltaTime);
			speech.text = str;
//			CurrentlySpeaking = str;
		}
		if(i == CurrentlySpeaking.Length)
		{
			CoroFin = true;
			Debug.Log ("Coro Is true????");
		    
		}
	}

	IEnumerator NextText()
	{
		yield return new WaitForSeconds (0.01f);
		CoroFin = false;
		speech.text = "";
		//SpeakCounter += 1;
	}
	IEnumerator clear()
	{
		yield return new WaitForSeconds (3);
		SpeakCounter = 2;
		speech.text = "";
		finishedspeaking = true;
		StopAllCoroutines ();
	}



}
