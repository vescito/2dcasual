using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAdOnSceneLoad : MonoBehaviour
{
    public GameObject mechanics;

    public void Load() {
        int rnd = Random.Range(0, 2);
        if(rnd == 0) {
            mechanics.GetComponent<PlayInterstitialAd>().ShowAd();
        }  
    }
}
