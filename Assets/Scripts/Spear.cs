using UnityEngine;

public class Spear : MonoBehaviour
{
    public GameObject spear;
    public bool CanAttack = true;
    public float AttackCooldown = 1f;
    public Transform Player;
    public Vector3 Offset;

    void Update()
    {
        transform.position = Player.position + Offset;

        if (Input.GetMouseButtonDown(0))
        {
            if (CanAttack)
            {
                SpearAttack();
            }
        }
    }

    public void SpearAttack()
    {
        CanAttack = false;
        //Animator anim = spear.GetComponent<Animator>();
        //anim.SetTrigger("Attack");
    }
    
    //IEnumerator ResetAttackCooldown()
    //{
    //    yield return new WaitForSeconds(AttackCooldown);
    //    CanAttack = true;
    //}
}
