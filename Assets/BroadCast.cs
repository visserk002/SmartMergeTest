using UnityEngine;
using System.Collections;

public class BroadCast : MonoBehaviour {

	public Transform leftController;
	public Transform rightController;

	public Transform go;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		leftController.rotation = transform.rotation;

		//leftController.localPosition = transform.localPosition;
	}
}
