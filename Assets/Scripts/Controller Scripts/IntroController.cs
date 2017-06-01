using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroController : MonoBehaviour {

	[SerializeField]
	Text text;
	[SerializeField]
	Animator textAnimator;

	void Start() {
		StartCoroutine (IntroSequence ());
	}

	void Update() {
		if (Input.anyKeyDown) {
			ScreenFader.instance.LoadScene ("MainMenu");
		}
	}

	IEnumerator IntroSequence() {
		yield return TimeManager.WaitForRealSeconds (2f);
		textAnimator.Play ("FadeIn");
		yield return TimeManager.WaitForRealSeconds (7f);
		StartCoroutine (ChangeText("However, the feat was so consuming and the inklike creature too powerful."));
		yield return TimeManager.WaitForRealSeconds (7f);
		StartCoroutine (ChangeText("The entity died."));
	}

	IEnumerator ChangeText(string text) {
		textAnimator.Play ("FadeOut");
		yield return TimeManager.WaitForRealSeconds (3f);
		this.text.text = text;
		textAnimator.Play ("FadeIn");
	}
}