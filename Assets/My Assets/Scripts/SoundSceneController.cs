using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundSceneController : MonoBehaviour {

	public AudioClip audioClip;


	public void Awake() {
		//SceneManager.sceneLoaded += LevelLoad;
	}


	//private void LevelLoad(Scene scene, LoadSceneMode loadSceneMode) {
	//	Debug.Log("level");
	//	SoundManager.main.ChangeSong(audioClip);
	//}

	private void OnLevelWasLoaded(int level) {
		SoundManager.main.ChangeSong(audioClip);
	}

}
