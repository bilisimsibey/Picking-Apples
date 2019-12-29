using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scriptSepet : MonoBehaviour
{
    public float hiz; //erişilebilir float türünde hiz değişkeni tanımlandı

    int skor; //tam sayı türünde skor değişkeni tanımlandı
    bool sag, sol;
    public float hiz2 = 10f;
    Rigidbody rb;
    public ParticleSystem particle;
    TextMeshProUGUI score_txt;
    private void Start()
    {
        score_txt = GameObject.Find("Canvas/score_txt").GetComponent<TextMeshProUGUI>();
        rb = GetComponent<Rigidbody>();
        particle.Stop();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="elma") //değen objenin tagı elma ise
        {
            skor += 10; //skora 10 ekle
            score_txt.text = "SCORE: " + skor;
            particle.Play();

            Destroy(collision.gameObject);

           //yonetici scripti için etkisiz hale getirildi   float rast = Random.Range(0.90f,11.70f); //float türünde rastgele değer içeren değişken tanımlandı

           //yonetici scripti için etkisiz hale getirildi collision.gameObject.transform.position = new Vector3(rast,7,-11.46f); //değen objenin transformu ayarlandı
        }
    }

    public void sagok()
    {
        sag = true;

    }
    public void sagok2()
    {
        sag = false;
    }

    public void solok()
    {
        sol = true;

    }

    public void solok2()
    {

        sol = false;
    }
    private void Update()
    {
        if (sag)
        {
            rb.velocity=(new Vector2(hiz2,rb.velocity.y));
        }
        if (sol)
        {
            rb.velocity = (new Vector2(-hiz2, rb.velocity.y));
        }
        if (Input.GetKey(KeyCode.RightArrow)) //sağ ok tusuna basılırsa
        {
            transform.Translate(hiz*Time.deltaTime,0,0); //saga dogru hareket
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //sol ok tusuna basılırsa
        {
            transform.Translate(-hiz*Time.deltaTime,0,0); //sola dogru hareket
        } 
    }
}
