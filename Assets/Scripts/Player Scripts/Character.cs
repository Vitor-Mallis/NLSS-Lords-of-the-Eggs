using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	[SerializeField]
	float health, maxHealth, mana, maxMana, strength, vigor, agility, intellect;

	GameObject[] inventory;

	Weapon equippedWeapon;

	public float GetAttack() {
		return strength * 4 / 3 + equippedWeapon.GetAttackPower () * 5/9;
	}

	public float GetDefense() {
		return vigor;
	}
}
