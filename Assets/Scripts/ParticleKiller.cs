using UnityEngine;

public class ParticleKiller : MonoBehaviour {
    public ParticleSystem ps;
	void Start () {
        ps = GetComponent<ParticleSystem>();
        Destroy(this.gameObject, ps.main.duration);
	}
}
