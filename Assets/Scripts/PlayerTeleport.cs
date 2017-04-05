using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerTeleport : MonoBehaviour {

	void Update() {
		if (GvrController.ClickButtonUp) {
			GvrLaserPointerImpl laserPointerImpl = (GvrLaserPointerImpl)GvrPointerManager.Pointer;
			if (laserPointerImpl.IsPointerIntersecting) {
				gameObject.transform.position = new Vector3(laserPointerImpl.PointerIntersection.x, gameObject.transform.position.y, laserPointerImpl.PointerIntersection.z);
			}
		}
	}
}
