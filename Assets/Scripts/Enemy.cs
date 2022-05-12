using UnityEngine;

public class Enemy : MonoBehaviour{

    public GameObject player;

    public int bossHealth = 100;
    public int damageAmount;
    public int damageCooldown;
    //public Collider collider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // look at player
        transform.LookAt(player.transform);


        //follow the player


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
}
