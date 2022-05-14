using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour{

    public GameObject player; 

    // Attacking Variables
    public int bossHealth = 100;
    public int damageAmount;
    public int damageCooldown;
    //public Collider collider;

    // AI Variables
    public float lookRadius = 10f;
    public NavMeshAgent agent;
    Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // look at player
        transform.LookAt(player.transform);

        //follow the player
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                //Attack the target
                //Look at the target potentially needed
            }
        }

        //If the player hits the boss, take damage
        if (player.transform.GetChild(3).GetComponent<Collider>().bounds.Intersects(GetComponent<Collider>().bounds))
        {
            Debug.Log(bossHealth);
            TakeDamage();
        }
    }

    void Die()
    {
        // dissapear and animation
        Destroy(gameObject);
    }
    void TakeDamage()
    {
        bossHealth--;
    }

    void Attack()
    {

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
