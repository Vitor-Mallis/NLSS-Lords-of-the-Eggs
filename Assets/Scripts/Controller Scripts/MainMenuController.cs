using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	[SerializeField]
	GameObject menuPanel;
	[SerializeField]
	Animator menuAnimator;

	public void ShowMenu() {
		menuPanel.SetActive (true);
		menuAnimator.Play ("SlideIn");
	}

	public void OnPressPlay() {
		SceneManager.LoadScene ("Gameplay");
	}

	public void OnPressOptions() {
		SceneManager.LoadScene ("Options");
	}

	public void OnPressQuit() {
		Application.Quit ();
	}
}
