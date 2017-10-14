using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

	Node node1;
	Node node2;
	Vector3 firstPosition;
	Vector3 secondPosition;
	bool isConnected;
	LineRenderer line;

	// Use this for initialization
	void Awake () {
		line = GetComponent<LineRenderer> ();
		isConnected = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isConnected) {
			Debug.Log (Input.GetMouseButton (0));
			if (Input.GetMouseButton (0)) {
				Vector3 uiPos = Input.mousePosition;
				uiPos.z = 0;
				secondPosition = Camera.main.ScreenToWorldPoint(uiPos);
				line.SetPosition (1, secondPosition);
			} else {
				Debug.Log ("unclicked");
				RaycastHit hit; 
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if ( Physics.Raycast (ray,out hit,100.0f)) {
					if (hit.transform.tag == "isNode") {
						SetSecondNode (hit.transform.GetComponent<Node> ());
						isConnected = true;
					}
				} else {
					Debug.Log ("destroyed line.");
					Destroy (this.gameObject);
				}
			}
		}
	}

	public void SetInitialNode (Node initialNode) {
		node1 = initialNode;

		firstPosition = node1.transform.position;
		line.SetPosition (0, firstPosition);
	}

	public void SetSecondNode (Node secondNode) {
		node2 = secondNode;
		secondPosition = node2.transform.position;
		line.SetPosition (1, secondPosition);
	}
}
