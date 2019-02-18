using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagement : MonoBehaviour {
    public string scenename;

    //scenemanagement for button UI
	public void buttonclick () {

        SceneManager.LoadScene(scenename);

    }
}
