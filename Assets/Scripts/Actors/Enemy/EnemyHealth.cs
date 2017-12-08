using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public float maxHealth;
    public float currentHealth; 

	void Start () {
        currentHealth = maxHealth;
	}
	
	void Update () {
		if(currentHealth <= 0) {
            Destroy(this.gameObject);
        }
	}

    void UpdateHealth(float amount) {
        currentHealth += amount;
    }
}
