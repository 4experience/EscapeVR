using UnityEngine;
using System.Collections;

public class Grasper : MonoBehaviour {
	
	public Transform transformA;
	public Transform transformB;
	public Transform bottom;
	public Vector3 topPosition;

	private bool movingSide = true;

	[Range(0.0f, 10.0f)] 
	public float speed = 1.0f;

	void Start () {
		topPosition = transform.position; // start on top position;
	}


	void Update () {

		if(movingSide){
			float t01 = (Mathf.Sin (Time.time * speed) + 1.0f) / 2.0f;
			Vector3 m = Vector3.Lerp (transformA.position, transformB.position, t01);
			transform.position = new Vector3(m.x, transform.position.y, m.z);
		} else { // moving down (or up)

		}
	}


	void Drop (){
		movingSide = false;
	}
}
