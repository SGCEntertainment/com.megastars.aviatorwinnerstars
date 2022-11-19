using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Sprite platform;

    [SerializeField] private GameObject starSound;
    [SerializeField] private GameObject platformSound;

    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void Update()
    {
        transform.Translate(new Vector2(0, speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = platform;
        }

        if (collision.gameObject.tag == "Airplan")
        {
            Player.instance.score -= 500;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Star")
        {
            Player.instance.score += 200;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
