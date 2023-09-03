using UnityEngine;
using TMPro;
public class WeaponController : MonoBehaviour
{
    
    public TMP_Text text;    
    public GameObject bulletPrefab; // Mermi prefab'ý
    public bool isReload=false; //Þarjör deðiþtiriyo mu
    public Transform firePoint; // Mermi atýþ noktasý
    public int magazineSize = 10; // Þarjör boyutu
    public float startingAmmo = Mathf.Infinity; // Baþlangýç mermi sayýsý
    public float reloadTime =0.5f;// Þarjör deðiþtirme süresi
    public float bulletSpeed = 10.0f; // Mermi hýzý
    public float fireRate = 0.2f; // Ateþ hýzý (saniyede mermi)
    public float recoilForce = 1.0f; // Geri tepme gücü
    public Camera playerCamera; // Kamera nesnesi
    public bool isZoomed = false; // Zoom durumu
    public float zoomFOV = 30.0f; // Zoom'da görüþ alaný
    public float normalFOV = 60.0f; // Normal görüþ alaný
    public int damagePerShot = 10; // Mermi baþýna verilecek hasar

    public int selectedWeapon=0;


    private int currentAmmo; // Þu anki mermi sayýsý
    private float nextFireTime = 0.0f; // Bir sonraki ateþ zamaný

    private void Start()
    {
        //m_AmmoUI=GetComponent<AmmoUI>();
        currentAmmo = magazineSize;
        
    }

    private void Update()
    {
        
        text.SetText("Mermi:"+currentAmmo);
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ToggleZoom();
        }

        if (isZoomed)
        {
            playerCamera.fieldOfView = zoomFOV;
        }
        else
        {
            playerCamera.fieldOfView = normalFOV;
        }

        if (Input.GetButtonDown("Fire1") && currentAmmo > 0)
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R) && currentAmmo < magazineSize && startingAmmo > 0)
        {
            Reload();
        }
    }

    private void Shoot()
    {
        currentAmmo--;
       
        nextFireTime = Time.time + 1.0f / fireRate;

        // Mermi prefab'ýný firePoint pozisyonunda ve rotasyonunda oluþturun
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Mermiye bir hýz verin
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = firePoint.forward * bulletSpeed;

        // Mermiye hasar verin
        BulletController bulletController = bullet.GetComponent<BulletController>();
        if (bulletController != null)
        {
            bulletController.SetDamage(damagePerShot);
        }

        // Geri tepme efekti
        playerCamera.transform.localRotation *= Quaternion.Euler(Vector3.left * recoilForce);

        Destroy(bullet, 1.2f);
        
    }

    //private void Reload()
    //{
    //    int bulletsToReload = magazineSize - currentAmmo;
    //    int bulletsAvailable = Mathf.Min(startingAmmo, bulletsToReload);
    //    currentAmmo += bulletsAvailable;
    //    startingAmmo -= bulletsAvailable;
    //}
    private void Reload()
    {
        isReload = true;
        Invoke("FinishReload", reloadTime);
    }private void FinishReload()
    {
        currentAmmo = magazineSize;
        isReload = false;
    }

    private void ToggleZoom()
    {
        isZoomed = !isZoomed;
    }
    
}
