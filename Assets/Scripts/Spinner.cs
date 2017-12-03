using UnityEngine;

public class Spinner : MonoBehaviour {
    public float rotateSpeed;

	void Update () {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
	}
}
