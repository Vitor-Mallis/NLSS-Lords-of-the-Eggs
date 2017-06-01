using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

	[SerializeField]
	GameObject menuPanel, pressAnyButton;
	[SerializeField]
	Animator menuAnimator;

	void Update() {
		if (Input.anyKeyDown) {
			if(!menuPanel.activeInHierarchy)
				ShowMenu ();
		}
	}

	public void ShowMenu() {
		menuPanel.SetActive (true);
		pressAnyButton.SetActive (false);
		menuAnimator.Play ("SlideIn");
	}

	public void OnPressPlay() {
		ScreenFader.instance.LoadScene ("Gameplay");
	}

	public void OnPressOptions() {
		ScreenFader.instance.LoadScene ("Options");
	}

	public void OnPressQuit() {
		Application.Quit ();
	}
}
