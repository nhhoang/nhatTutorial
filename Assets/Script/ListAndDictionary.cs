using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListAndDictionary : MonoBehaviour {

	void Start() {
		List<BadGuy> badguys = new List<BadGuy>();

		badguys.Add(new BadGuy("Harvey", 50));
		badguys.Add(new BadGuy("Magneto", 100));
		badguys.Add(new BadGuy("Pip", 5));
		Debug.Log(badguys.Count);
		badguys.Insert(1, new BadGuy("Orochi", 50));
		badguys.Sort();
		foreach(BadGuy guy in badguys) {
			Debug.Log(guy.name + " " + guy.power);
		}
		Debug.Log(badguys.Count);

		Dictionary<string, BadGuy> badguysDic = new Dictionary<string, BadGuy>();
		badguysDic.Add("guy1",new BadGuy("Harvey", 50));
		badguysDic.Add("guy2",new BadGuy("Magneto", 100));
		badguysDic.Add("guy3",new BadGuy("Pip", 5));
		Debug.Log(badguysDic["guy1"].name);
	}
}
