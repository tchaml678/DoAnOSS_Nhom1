using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    private Bullet damageBullet;
    [SerializeField] GameObject bossBang;
    [SerializeField] int bossHP ;
    [SerializeField] int bodyDamage;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            damageBullet = collision.gameObject.GetComponent<Bullet>();
            bossHP -= damageBullet.Damage();
            if (bossHP <= 0)
            {
                var onBossBang = Instantiate(bossBang, transform.position, transform.rotation);
                Destroy(onBossBang, 2.6f);
                Destroy(gameObject);
            }
        }
        
    }

    public int Damage()
    {
        return bodyDamage;
    }
}
