using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueDatabase : MonoBehaviour {

     public List<string> Talking = new List<string>();
	public string Words;

	// Use this for initialization
	void Start () 
	{
		Words = "";
		string Chatter01 = "So glad there's no \n no violence in this town";
		string Chatter02 = "What a lovely day!";
		string Chatter03 = "I'm so glad there's no \n guns in this town";
		string Chatter04 = "I wonder what's on sale \n at the shop";
		string Chatter05 = "Nothing exciting happens \n around here";
		string Chatter06 = "Another violence free day!";
		string Chatter07 = "Another murder free day!";
		string Chatter08 = "What the heck IS Ludonarrative \n Dissonance???";

		Talking.Add (Chatter01);
		Talking.Add (Chatter02);
		Talking.Add (Chatter03);
		Talking.Add (Chatter04);
		Talking.Add (Chatter05);
		Talking.Add (Chatter06);
		Talking.Add (Chatter07);
		Talking.Add (Chatter08);
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		StartCoroutine (Henlo ());
		
	}

	IEnumerator Henlo ()
	{
		yield return new WaitForSeconds (10);
		Words = Talking [Random.Range (0, Talking.Count)];
		print (Words);
		StopAllCoroutines ();
	}
}
