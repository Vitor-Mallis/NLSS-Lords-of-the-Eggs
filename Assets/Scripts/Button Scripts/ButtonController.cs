using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	[SerializeField]
	KeyCode nextKey, previousKey;

	[SerializeField]
	UIButton[] buttons;

	int selectedButton;

	void Start() {
		selectedButton = 0;

		buttons [selectedButton].Highlight ();
	}

	void OnEnable() {
		selectedButton = 0;

		buttons [selectedButton].Highlight ();
	}

	void Update() {
		if (Input.GetKeyDown (nextKey)) {
			if (selectedButton < buttons.Length - 1) {
				buttons[selectedButton].Up();
				buttons[selectedButton+1].Highlight ();
				selectedButton++;
			}
		} else if (Input.GetKeyDown (previousKey)) {
			if (selectedButton > 0) {
				buttons[selectedButton].Up();
				buttons[selectedButton-1].Highlight ();
				selectedButton--;
			}
		} else if (Input.GetKeyDown (KeyCode.X)) {
			buttons [selectedButton].Down ();
		}
	}
}
