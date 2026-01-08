using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject puanEfekt; // Puan efekti prefab'i buraya atanacak

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Player")
        {
            score.yildizpuani_int += 1; // Skoru 1 artırır.
            FindObjectOfType<SoundScript>().PlayCoinSound(); // Coin sesini çalar.
            
            GameObject efekt = Instantiate(puanEfekt, transform.position, Quaternion.identity); // Puan efektini oluşturur.
            Destroy(efekt, efekt.GetComponent<ParticleSystem>().main.duration); // Efekti belirli bir süre sonra yok eder.

            Destroy(this.gameObject); // Coin objesini yok eder.
        }
    }
}
