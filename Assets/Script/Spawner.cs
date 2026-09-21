using UnityEngine;

public class Spawner : MonoBehaviour
{
    private static Transform MonstersParent;
    [SerializeField] private Transform center;
    [SerializeField] private GameObject monsterPrefab;
    [SerializeField] private int maxAlive = 30;
    [SerializeField] private float spawnInterval = 1.0f;

    [SerializeField] private float spawnRadius = 15.0f;
    [SerializeField] private float yOffset = 0f;

    [SerializeField] private Transform target;

    private int aliveCount = 0;

    private void Awake()
    {
        if (center == null) center = transform;
    }

    private void Start()
    {
        MonstersParent = transform.GetChild(0);
        InvokeRepeating(nameof(SpawnOnce), 0f, spawnInterval);
    }

    public void getOutUI_A(GameObject obj) {
        Time.timeScale = 1.0f;
        MonsterHide(false);
        obj.SetActive(false);
    }

    public static void MonsterHide(bool hide) {
        MonstersParent.gameObject.SetActive(!hide);
    }

    private void SpawnOnce() {
        Vector3 randomPos = getRandomPointAroundCenter();
        var go = Instantiate(monsterPrefab, randomPos, Quaternion.identity);
        go.transform.SetParent(MonstersParent);
        var monster = go.GetComponent<Monster>();
        monster.setTarget(target);
    }

    private Vector3 getRandomPointAroundCenter() {
        //Random.insideUnitSphere¿∫ vector3, insideUnitCircle¿∫ vector2
        Vector2 r = Random.insideUnitCircle* spawnRadius;
        Vector3 pos = center.position + new Vector3(r.x, 0f, r.y);
        pos.y += yOffset;
        return pos;
    }
}
