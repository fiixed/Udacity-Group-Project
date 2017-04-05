using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyScript : Photon.MonoBehaviour {

	public GameObject Text;

	private void Start() {
		if (photonView.isMine) {
			GetComponent<PhotonVoiceRecorder>().enabled = true;
			GetComponent<MeshRenderer>().enabled = false;
			
			
		}
	}
	// Update is called once per frame
	void Update () {
		if (photonView.isMine) {
			transform.position = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
			transform.rotation = GameObject.FindGameObjectWithTag("MainCamera").transform.rotation;
		}
	}
}
