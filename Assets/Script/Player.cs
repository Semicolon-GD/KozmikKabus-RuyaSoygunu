using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float distanceFromTarget; //etkile�ime ge�ecegimiz nesnelerin uzakl�g�
    public float toTarget; //bakt�g�m�z her nesnenin uzakl�g� 



    void Update()
    {
        RaycastHit hit; //���n demeti olu�turduk

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit)) //physics bizim g�rmedigimiz fiziki bir alan/nesne olu�turur.Bizim olu�turdugumuz nesneye �arp�p �arpmad�g�n� kontrol eder  
        {                                       //transform position karekterin pozyonundan ��kacag�n� belirtiyoruz ���n�n
                                                //transform.TransformDirection karekterin y�n�ne dogru 3 boyutlu d�nyada ileriye dogru gitsin
                                                //out ise ��kt� olarak ���n demeti olsun diyoruz
                                                //distance uzunluk 

            toTarget = hit.distance;
            distanceFromTarget = toTarget;

        }
    }
}
