using UnityEngine;

public class Explosion : MonoBehaviour
{
    public Sprite[] frames;
    public float frameDuration = 0.1f;

    private SpriteRenderer spriteRenderer;
    private int currentFrame;
    private float timer;

    void Start()
    {
        spriteRenderer =
            GetComponent<SpriteRenderer>();

        spriteRenderer.sprite =
            frames[0];
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= frameDuration)
        {
            timer = 0;

            currentFrame++;

            if(currentFrame >= frames.Length)
            {
                Destroy(gameObject);
                return;
            }

            spriteRenderer.sprite =
                frames[currentFrame];
        }
    }
}