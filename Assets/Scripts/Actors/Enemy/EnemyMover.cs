using UnityEngine;
using UnityEngine.AI;

public class EnemyMover : MonoBehaviour {

    public float viewDistance;
    public Transform target;

    public Transform[] patrolPoints;
    public int nextPoint = 0;

    NavMeshAgent agent;

    void Start () {
        agent = GetComponent<NavMeshAgent>();
        // load target if null
	}
	
	void Update () {
		if(Vector3.Distance(target.position, this.transform.position) <= viewDistance)
        {
            agent.destination = target.position;
        } else
        {
            // stop
            agent.destination = this.transform.position;
            // patrol
        }
	}
}
