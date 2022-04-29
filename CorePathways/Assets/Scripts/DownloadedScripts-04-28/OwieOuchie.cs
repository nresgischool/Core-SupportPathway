using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUPERCharacter;

public class OwieOuchie : MonoBehaviour
{
    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;

    public float health = 100;

    Vector3 wanderTarget = Vector3.zero;
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        Wander();
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("fiorhj");
            col.gameObject.GetComponent<SUPERCharacterAIO>().ImmediateStateChange(-50, StatSelector.Health);
        }
        if (col.gameObject.tag == "Projectile")
        {
            health -= 25;
            Debug.Log("hit");
        }
    }

    void Wander()
    {
        float wanderRadius = 10;
        float wanderDistance = 10;
        float wanderJitter = 1;

        wanderTarget += new Vector3(Random.Range(-1.0f, 1.0f) * wanderJitter,
                                            0,
                                            Random.Range(-1.0f, 1.0f) * wanderJitter);
        wanderTarget.Normalize();
        wanderTarget *= wanderRadius;

        Vector3 targetLocal = wanderTarget + new Vector3(0, 0, wanderDistance);
        Vector3 targetWorld = this.gameObject.transform.InverseTransformVector(targetLocal);

        Seek(targetWorld);
    }

    void Seek(Vector3 location)
    {
        agent.SetDestination(location);
    }
}
