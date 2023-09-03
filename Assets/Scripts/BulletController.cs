using UnityEngine;

public class BulletController : MonoBehaviour
{
    private int damage = 10; // Mermi hasarý

    // Hasarý ayarlamak için bu fonksiyonu kullanabilirsiniz
    public void SetDamage(int newDamage)
    {
        damage = newDamage;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Çarpýþan nesneye hasar uygulayýn (örneðin düþmanlar için kullanabilirsiniz)
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

