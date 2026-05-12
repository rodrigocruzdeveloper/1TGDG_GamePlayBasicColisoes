using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Apple : MonoBehaviour
{
    int score;

    private void Update()
    {
        if (transform.position.y < -5.0f)
        {
            Back();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Back();
            score++;
            print("Score: " + score);
        }
    }

    void Back()
    {
        transform.position = new Vector2(Random.Range(-8.0f, 8.0f), 7.0f);
    }
}
