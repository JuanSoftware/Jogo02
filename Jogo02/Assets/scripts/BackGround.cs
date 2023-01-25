using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sprite = GetComponentInChildren<SpriteRenderer>();
        Vector3 scaleTemp = GetComponentInChildren<Transform>().transform.localScale;

        float widht = sprite.bounds.size.x;
        float height = sprite.bounds.size.y;
        float heightCamera = Camera.main.orthographicSize * 2.0f;
        float widhtworld = heightCamera / Screen.height * Screen.width;

        scaleTemp.x = widhtworld / widht;
        scaleTemp.y = heightCamera/ height;

        transform.localScale= scaleTemp;
    }
}
