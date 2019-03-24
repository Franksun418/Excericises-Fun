using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour {

    int health = 100;
    Rigidbody2D rgbd2d;
    SpriteRenderer spriteRenderer;
    Color color;
    AudioSource audioSource;
    [SerializeField]
    HUD hUD;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        color = spriteRenderer.color;
        rgbd2d = GetComponent<Rigidbody2D>();
        rgbd2d.AddForce(new Vector2(15, 10), ForceMode2D.Impulse);
	}
    void OnCollisionEnter2D(Collision2D collision2D)
    {

        health -= 10;

        color.a -= 0.1f;
        spriteRenderer.color =color;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        audioSource.Play();
        hUD.AddScore();
    }
}
