using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text Instructions;


	public void Quit()
	{
		//Instructions.SetActive (true);
		Application.Quit();
	}

//	//public Transform[] SpawnPos;
//	private PlayerInteraction PI;
//	public GameObject Enemy;
//	private int SpawnCounter;
//	//List<GameObject> enemyNum = new List<GameObject>();
//	public GameObject[] enemyNum;
//	int EnemyCounter;
//	// Use this for initialization
//	void Start () 
//	{
//		//EnemyCounter = 0;
//
//		PI = FindObjectOfType<PlayerInteraction> ();
//		EnemyCounter = PI.DeathCount;
//		//enemyNum = GameObject.FindGameObjectsWithTag("Enemy");
//		//EnemyCounter = 0;
//		SpawnCounter = 0;
//		foreach(GameObject go in enemyNum)
//		{
//			go.SetActive (false);
//		}
//		
//	}
//	
//	// Update is called once per frame
//	void FixedUpdate () 
//	{
//		SpawnEnemies ();
//		//EnemyCounter = enemyNum.Length;
//		//EnemyCounter = GameObject.FindGameObjectsWithTag("Enemy").length;
//		EnemyCounter = PI.DeathCount;
//		print (EnemyCounter);
//		//EnemyCounter = GameObject.FindGameObjectsWithTag ("Enemy").Length;
//	}
//
//	void SpawnEnemies()
//	{
//		switch(SpawnCounter)
//		{
//		case 0:
//			
//			//StartCoroutine (Spawn (enemyNum [0], enemyNum [1], enemyNum [2]));
////			EnemyCounter += -GameObject.FindGameObjectsWithTag ("Enemy").Length;
//				SpawnCounter = 1;
//			
//
//			break;
//		case 1:
//			print ("WOOOORK");
//
//			//StopCoroutine(Spawn (enemyNum [0], enemyNum [1], enemyNum [2]));
//			if(EnemyCounter == 8)
//			{
//				StartCoroutine (Spawn (enemyNum [3], enemyNum [4], enemyNum [5]));
//				SpawnCounter = 2;
//			}
//
//			break;
//		case 2:
//			StopCoroutine (StartCoroutine (Spawn (enemyNum [3], enemyNum [4], enemyNum [5])));
//			break;
//		}
//
//
//	}
//
//	IEnumerator Spawn(GameObject a,GameObject b, GameObject c)
//	{
//		yield return new WaitForSeconds (0.1f);
//		//Instantiate (Enemy, a, a);
//		print("SPAWN");
//		a.SetActive(true);
//		b.SetActive(true);
//		c.SetActive(true);
//		StopAllCoroutines();
//	
//	}
}
