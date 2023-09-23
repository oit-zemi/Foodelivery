using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    public Sprite idleImage;
    public Sprite jumpImage;

    public Sprite idleImage_Pizza1;
    public Sprite idleImage_Pizza2;
    public Sprite idleImage_Pizza3;

    public Sprite jumpImage_Pizza1;
    public Sprite jumpImage_Pizza2;
    public Sprite jumpImage_Pizza3;

    private int PizzaCount = 0;

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
            switch(PizzaCount) {
                case 0:
                    sr.sprite = jumpImage;
                    break;
                case 1:
                    sr.sprite = jumpImage_Pizza1;
                    break;
                case 2:
                    sr.sprite = jumpImage_Pizza2;
                    break;
                default:
                    sr.sprite = jumpImage_Pizza3;
                    break;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            switch(PizzaCount) {
                case 0:
                    sr.sprite = idleImage;
                    break;
                case 1:
                    sr.sprite = idleImage_Pizza1;
                    break;
                case 2:
                    sr.sprite = idleImage_Pizza2;
                    break;
                default:
                    sr.sprite = idleImage_Pizza3;
                    break;
            }
        }
    }
}