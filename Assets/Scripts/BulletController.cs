using UnityEngine;

public class BulletController : MonoBehaviour
{
    private int damage = 10; // Mermi hasar�

    // Hasar� ayarlamak i�in bu fonksiyonu kullanabilirsiniz
    public void SetDamage(int newDamage)
    {
        damage = newDamage;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �arp��an nesneye hasar uygulay�n (�rne�in d��manlar i�in kullanabilirsiniz)
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            //if (enemyHealth != null)
            //{
            //    enemyHealth.TakeDamage(damage);
            //}
        }

        // Mermiyi yok edin
        Destroy(gameObject);
    }
}

