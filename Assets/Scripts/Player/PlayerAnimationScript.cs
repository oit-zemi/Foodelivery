using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    public Sprite defaultImage;
    public Sprite jumpImage;
    SpriteRenderer sr;

    void Start()
    {
        // SpriteのSpriteRendererコンポーネントを取得
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            sr.sprite = jumpImage;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            sr.sprite = defaultImage;
        }
    }
}
