﻿using UnityEngine;
using System.Collections;
using System;

public class BadGuy : IComparable<BadGuy> {

	public string name;
	public int power;

	public BadGuy(string newName, int newPower) {
		name = newName;
		power = newPower;
	}

	public int CompareTo(BadGuy others) {
		return this.power.CompareTo(others.power);
	}
}
