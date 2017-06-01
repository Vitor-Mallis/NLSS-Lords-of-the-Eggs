using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour {
	public Button button {get; private set;}

	Graphic targetGraphic;
	Color normalColor;

	public bool isSelected;

	void Awake() {
		button = GetComponent<Button>();
		targetGraphic = GetComponent<Graphic>();

		ColorBlock cb = button.colors;
		cb.disabledColor = cb.normalColor;
		button.colors = cb;
	}

	void Start() {
		Up();
	}

	public void Up() {
		StartColorTween(button.colors.normalColor, false);
		isSelected = false;
	}

	public void Highlight() {
		StartColorTween(button.colors.highlightedColor, false);
		isSelected = true;
	}

	public void Down() {
		button.onClick.Invoke ();
	}

	void StartColorTween(Color targetColor, bool instant) {
		if (targetGraphic == null)
			return;

		targetGraphic.CrossFadeColor(targetColor, instant ? 0f : button.colors.fadeDuration, true, true);
	}

	void OnApplicationFocus(bool focus) {
		Up();
	}
}