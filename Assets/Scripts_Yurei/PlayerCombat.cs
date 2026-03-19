using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private Animator _Yurei;
    public Transform attackPoint;
    public float weaponRange = 1f;
    public LayerMask enemyLayer;
    public int damage = 1;


    void Update()
    {
        PlayerAttack1();
    }

    public void PlayerAttack1()
    {
        //Checking for attacking animation bool
        if (Input.GetMouseButtonDown(0))
        {
            _Yurei.SetTrigger("Attack");
            Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.position, weaponRange, enemyLayer); 

            foreach (Collider2D enemy in enemies)
            {
                OrcHealth OrcHealth = enemy.GetComponent<OrcHealth>();

                if (OrcHealth != null)
                {
                    OrcHealth.ChangeHealthOrc(-1);
                }
            }

        }
    }
}
