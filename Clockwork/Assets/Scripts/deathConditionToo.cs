using UnityEngine;
using System.Collections;

public class deathConditionToo : MonoBehaviour {
	
	public GameObject leGrimReaper;
	private grimReaper gr;
	
	
	void Start () {
		gr = leGrimReaper.GetComponent<grimReaper>();
	}
	
	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			//Debug.Log ("Too TriggerStay works");
			gr.conditionToo = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			//Debug.Log ("Too TriggerExit works");
			gr.conditionToo = false;
		}
	}
}
