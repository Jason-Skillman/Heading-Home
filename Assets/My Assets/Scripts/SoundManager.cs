using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager main = null;

	private AudioSource audioSource;


	private void Awake() {
		if(main == null) {
			main = this;
		} else if(main != this) {
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);

		audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void ChangeSong(AudioClip audioClip) {
		audioSource.clip = audioClip;
		audioSource.Play();
	}

	//public void PlayMusic(AudioClip audioClip) {
	//	audioSource.clip = audioClip;
	//	audioSource.Play();
	//}

}
