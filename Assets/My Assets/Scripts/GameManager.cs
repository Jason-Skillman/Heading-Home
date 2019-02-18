using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//Singleton
	public static GameManager main;
	
	public bool flagHelpFood = false;
	public bool flagHelpAnimal = false;
	public bool flagHelpMusic = false;
	public bool flagPlayedIntro = true;


	void Awake() {
		DontDestroyOnLoad(gameObject);

		//Singleton
		if(!main) main = this;
		else Destroy(gameObject);
	}
	
	void Update() {

	}

	public void FoodComplete() {
		flagHelpFood = true;
	}

	public void AnimalsComplete() {
		flagHelpAnimal = true;
	}

	public void MusicComplete() {
		flagHelpMusic = true;
	}

}
