using UnityEngine;
using System.Collections;

public class obligatorySecret : MonoBehaviour {

	private bool fourty;
	private bool d;
	private bool a;
	private bool n;
	private bool canEnterFourtyTwo = true;
	private bool canEnterDank = true;
	public static bool dankSecret;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha4) && canEnterFourtyTwo) {
			fourty = true;
		}
		if (Input.GetKeyDown (KeyCode.Alpha2) && fourty && canEnterFourtyTwo) {
			Application.LoadLevel("EndScreen");
			dankSecret = false;
			canEnterFourtyTwo = false;
			canEnterDank = false;
		}
		if (Input.GetKeyDown (KeyCode.D) && !a && !n && canEnterDank) {
			d = true;
		}
		if (Input.GetKeyDown (KeyCode.A) && d && !n && canEnterDank) {
			a = true;
		}
		if (Input.GetKeyDown (KeyCode.N) && d && a && canEnterDank) {
			n = true;
		}
		if (Input.GetKeyDown (KeyCode.K) && d && a && n && canEnterDank) {
			dankSecret = true;
			canEnterFourtyTwo = false;
			canEnterDank = false;
		}
	}
}
