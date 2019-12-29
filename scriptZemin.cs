using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scriptZemin : MonoBehaviour
{

    Image redkalp; //ımage türünde değişken tanımlandı
    public GameObject stop_pnl; //public türünde gameobject cinsinden değişken tanımlandı
    private void Start()
    {
        redkalp = GameObject.Find("Canvas/blackkalp/redkalp").GetComponent<Image>(); //değişkene değer atandı
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="elma") //degen objenin tagı elma ise
        {
         //   Debug.Log("Zemine çarptı"); //console a yazdır

            redkalp.fillAmount -= 0.10f; //ımage değişkeninin fill amount değeri eksiltildi

            if (redkalp.fillAmount==0) //eğer fillamount değeri sıfırlanırsa
            {
                stop_pnl.SetActive(true); //paneli aktifleştir
                Time.timeScale = 0; //oyunu durdur
            }

            Destroy(collision.gameObject); //değen objeyi yok et

         //yonetici scripti için etkisiz hale getirildi   float rast = Random.Range(0.90f, 11.70f); //float türünde rastgele değeren içeren değişken tanımlandı

         //yonetici scripti için etkisiz hale getirildi   collision.gameObject.transform.position = new Vector3(rast, 7, -11.46f); //değen objenin transformu yeniden ayarlandı
        }
    }
}
