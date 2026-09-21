using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 15.0f;
    [SerializeField] private float lifetime = 5.0f;
    [SerializeField] private GameObject hitEffectPrefab;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    private void Start()
    {
        //angularVelocity는 회전, linearVelocity 는 이동, velocity는 지원x
        rb.linearVelocity = transform.forward * speed;
        Destroy(gameObject,lifetime);
    }

    private void OntriggerEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Monster"))
        {
            other.gameObject.GetComponent<Monster>().getDamage(10);
            Instantiate(hitEffectPrefab, transform.position, Quaternion.identity);
        }
    }
}
