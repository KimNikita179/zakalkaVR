using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SmokeController : MonoBehaviour
{
    public ParticleSystem smokeParticles;  // ¬³¬ã¬í¬Ý¬Ü¬Ñ ¬ß¬Ñ ¬ã¬Ú¬ã¬ä¬Ö¬Þ¬å ¬é¬Ñ¬ã¬ä¬Ú¬è
    public float delaySeconds = 2f;       // ¬©¬Ñ¬Õ¬Ö¬â¬Ø¬Ü¬Ñ ¬Ó ¬ã¬Ö¬Ü¬å¬ß¬Õ¬Ñ¬ç

    // ¬£¬í¬Ù¬í¬Ó¬Ñ¬Ö¬ä¬ã¬ñ ¬á¬â¬Ú ¬ß¬Ñ¬Ø¬Ñ¬ä¬Ú¬Ú ¬Ü¬ß¬à¬á¬Ü¬Ú
    public void StartSmokeAfterDelay()
    {
        Invoke("PlaySmoke", delaySeconds); // ¬©¬Ñ¬á¬å¬ã¬Ü ¬Õ¬í¬Þ¬Ñ ¬é¬Ö¬â¬Ö¬Ù 18 ¬ã¬Ö¬Ü¬å¬ß¬Õ
    }

    private void PlaySmoke()
    {
        if (smokeParticles != null)
        {
            smokeParticles.Play();         // ¬£¬Ü¬Ý¬ð¬é¬Ú¬ä¬î ¬Õ¬í¬Þ
        }
        else
        {
            Debug.LogError("ParticleSystem ¬ß¬Ö ¬ß¬Ñ¬Ù¬ß¬Ñ¬é¬Ö¬ß!");
        }
    }
}