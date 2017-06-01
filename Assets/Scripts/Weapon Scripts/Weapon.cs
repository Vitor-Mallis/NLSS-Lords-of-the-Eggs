using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Weapon : MonoBehaviour {

	[SerializeField]
	AudioClip attackSound;
	[SerializeField]
	float attackPower;

	public float GetAttackPower() {
		return attackPower;
	}
}
