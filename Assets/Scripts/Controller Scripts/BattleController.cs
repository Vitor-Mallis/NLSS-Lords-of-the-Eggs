using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {

	[SerializeField]
	GameObject attackPanel, skillsPanel, itemsPanel, menuBtnController, skillsBtnController, itemsBtnController;

	List<GameObject> characters;

	int round = 0, turn = 0;

	void Start() {
		foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player"))
			characters.Add (player);

		foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
			characters.Add (enemy);
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Z)) {
			OnPressBack ();
		}
	}

	public void OnPressAttack() {

	}

	public void OnPressSkills() {
		attackPanel.SetActive (false);
		skillsPanel.SetActive (true);
		menuBtnController.SetActive(false);
		skillsBtnController.SetActive (true);
	}

	public void OnPressItems() {
		attackPanel.SetActive (false);
		itemsPanel.SetActive (true);
		menuBtnController.SetActive(false);
		itemsBtnController.SetActive (true);
	}

	public void OnPressRun() {
		ScreenFader.instance.LoadScene ("Gameplay");
	}

	public void OnPressBack() {
		if (skillsPanel.activeInHierarchy) {
			skillsPanel.SetActive (false);
			skillsBtnController.SetActive (false);
		} else if (itemsPanel.activeInHierarchy) {
			itemsPanel.SetActive (false);
			itemsBtnController.SetActive (false);
		}

		attackPanel.SetActive (true);
		menuBtnController.SetActive (true);
	}
}
