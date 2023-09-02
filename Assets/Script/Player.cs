using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float distanceFromTarget; //etkileþime geçecegimiz nesnelerin uzaklýgý
    public float toTarget; //baktýgýmýz her nesnenin uzaklýgý 



    void Update()
    {
        RaycastHit hit; //ýþýn demeti oluþturduk

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit)) //physics bizim görmedigimiz fiziki bir alan/nesne oluþturur.Bizim oluþturdugumuz nesneye çarpýp çarpmadýgýný kontrol eder  
        {                                       //transform position karekterin pozyonundan çýkacagýný belirtiyoruz ýþýnýn
                                                //transform.TransformDirection karekterin yönüne dogru 3 boyutlu dünyada ileriye dogru gitsin
                                                //out ise çýktý olarak ýþýn demeti olsun diyoruz
                                                //distance uzunluk 

            toTarget = hit.distance;
            distanceFromTarget = toTarget;

        }
    }
}
