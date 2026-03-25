using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public List <Sprite> skySprites;
    void Start()
    {
        Sprite s = skySprites[Random.Range(0, skySprites.Count)];
        this.gameObject.GetComponent<SpriteRenderer>().sprite = s;
    }

}
