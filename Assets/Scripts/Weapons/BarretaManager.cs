﻿using UnityEngine;
using System.Collections;

public class BarretaManager : MonoBehaviour {
	public string Name;

	public int Damage;
	public int Ammo;

	public bool isActive = false;

	public int weaponNum = 0;

	public Transform Player;

	public Vector2 Offset;

	void Start (){
	}

	void Update () {
		//rotation
		if (isActive) {
			Vector2 tempOff = new Vector2 ();
			tempOff.x = Player.position.x + Offset.x;
			tempOff.y = Player.position.y + Offset.y;

			transform.position = tempOff;

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = 5.23f;

			Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
			mousePos.x = mousePos.x - objectPos.x;
			mousePos.y = mousePos.y - objectPos.y;

			float angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle));
		}
	}

}
