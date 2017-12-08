using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public float maxHealth = 3.0f;
    public float currentHealth;

	void Start () {
        currentHealth = maxHealth;
	}
	
	void Update () {
		if(currentHealth <= 0) {
            // restart level?
            // move back to last check point?
        }
	}

    void UpdateHealth(float amount) {
        currentHealth += amount;
    }
}
