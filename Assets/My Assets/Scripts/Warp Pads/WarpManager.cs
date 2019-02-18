using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpManager : MonoBehaviour {

	//Singleton
	public static WarpManager main;

	private Player player;
	private string sceneName;
	private int warpID;
	private WarpPadOut[] warpPadsOut;


	void Awake() {
		DontDestroyOnLoad(gameObject);

		//Singleton
		if(!main) main = this;
		else Destroy(gameObject);

		SceneManager.sceneLoaded += OnLevelLoaded;
		//SceneFaderManager.main.OnFadeIn += OnLevelLoaded;
	}

	//Main method
	public void WarpToLevel(Player player, string sceneName, int warpID) {
		this.player = player;
		this.sceneName = sceneName;
		this.warpID = warpID;
		
		SceneFaderManager.main.FadeToScene(sceneName);
	}

	//Scene scene, LoadSceneMode loadSceneMode
	public void OnLevelLoaded(Scene scene, LoadSceneMode loadSceneMode) {
		warpPadsOut = GameObject.FindObjectsOfType<WarpPadOut>();

		for(int i = 0; i < warpPadsOut.Length; i++) {
			if(warpPadsOut[i].warpID == warpID) {
				player.gameObject.transform.position = warpPadsOut[i].gameObject.transform.position - new Vector3(0.5f, -0.5f, 0f);
				warpPadsOut[i].OnWarpOut(player, sceneName);
				break;
			}
		}
	}

}
