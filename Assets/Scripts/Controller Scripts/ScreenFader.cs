using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour {

	public static ScreenFader instance;

	[SerializeField]
	GameObject panel;
	[SerializeField]
	Animator panelAnimator;

	void Awake() {
		MakeSingleton ();
	}

	void MakeSingleton() {
		if (instance != null) {
			Destroy (this.gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		}
	}

	public void LoadScene(string scene) {
		StartCoroutine (LoadSceneRoutine (scene));
	}

	IEnumerator LoadSceneRoutine(string scene) {
		panel.SetActive (true);
		panelAnimator.Play ("FadeOut");
		yield return StartCoroutine (TimeManager.WaitForRealSeconds (1f));
		SceneManager.LoadScene (scene);
		panelAnimator.Play ("FadeIn");
		yield return StartCoroutine (TimeManager.WaitForRealSeconds (1f));
		panel.SetActive (false);
	}
}
