using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonrakiSeviyeScript : MonoBehaviour
{
    public void sonrakiseviyebutton()
    {
        SceneManager.LoadScene(2); // Sahneyi 2. indekste bulunan sahneye değiştirir.
    }
}
