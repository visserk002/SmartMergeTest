using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public Camera c;
	// Use this for initialization
	void Start () {
		c.fieldOfView += 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
