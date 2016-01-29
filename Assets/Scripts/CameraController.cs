using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	// LateUpdate is guaranteed to run after all items have been processed in Update
	// so when we set position of the camera,
	// we know absolutely that the player has already moved in that frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
