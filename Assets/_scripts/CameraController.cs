using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;



	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// We use LateUpdate to ensure that the player object has already been updated for this frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
