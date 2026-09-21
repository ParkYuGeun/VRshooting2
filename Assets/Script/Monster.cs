using UnityEngine;
using UnityEngine.AI;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

public class Monster : MonoBehaviour
{
    [SerializeField] private HapticImpulsePlayer hapticPlayer;
    [SerializeField] private float rePathInterval = 0.15f;
    [SerializeField] private GameObject DeadParticle;
    private int hp = 50;
    private Transform target;
    private NavMeshAgent agent;
    private float nextRepathTime;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void setTarget(Transform T)
    {
        target = T;
    }

    private void Update()
    {
        if (target == null) return;

        if (Time.time >= nextRepathTime)
        {
            nextRepathTime = Time.time + rePathInterval;
            agent.SetDestination(target.position);
        }
    }

    public void getDamage(int value) {
        hp -= value;
        if (hp <= 0) {  
            Instantiate(DeadParticle, transform.position + Vector3.up, Quaternion.identity);
            hapticPlayer.SendHapticImpulse(1.0f, 0.3f);
            Destroy(this.gameObject);
        }
    
     }
}

