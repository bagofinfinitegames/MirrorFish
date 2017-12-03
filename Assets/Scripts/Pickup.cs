using UnityEngine;

public class Pickup : MonoBehaviour {
    public GameObject particles;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit it!");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(other.gameObject.tag);
            Instantiate(particles, transform.position, Quaternion.identity);
            // add to player stuffs
            Destroy(this.gameObject);
        }
    }
}
