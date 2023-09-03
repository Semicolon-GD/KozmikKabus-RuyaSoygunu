using UnityEngine;
using TMPro;
public class WeaponController : MonoBehaviour
{
    
    public TMP_Text text;    
    public GameObject bulletPrefab; // Mermi prefab'�
    public bool isReload=false; //�arj�r de�i�tiriyo mu
    public Transform firePoint; // Mermi at�� noktas�
    public int magazineSize = 10; // �arj�r boyutu
    public float startingAmmo = Mathf.Infinity; // Ba�lang�� mermi say�s�
    public float reloadTime =0.5f;// �arj�r de�i�tirme s�resi
    public float bulletSpeed = 10.0f; // Mermi h�z�
    public float fireRate = 0.2f; // Ate� h�z� (saniyede mermi)
    public float recoilForce = 1.0f; // Geri tepme g�c�
    public Camera playerCamera; // Kamera nesnesi
    public bool isZoomed = false; // Zoom durumu
    public float zoomFOV = 30.0f; // Zoom'da g�r�� alan�
    public float normalFOV = 60.0f; // Normal g�r�� alan�
    public int damagePerShot = 10; // Mermi ba��na verilecek hasar

    public int selectedWeapon=0;


    private int currentAmmo; // �u anki mermi say�s�
    private float nextFireTime = 0.0f; // Bir sonraki ate� zaman�

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

        // Mermi prefab'�n� firePoint pozisyonunda ve rotasyonunda olu�turun
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Mermiye bir h�z verin
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
