using UnityEngine;

public class PlayerController : MonoBehaviour{
    public float speed = 5f;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Sprite straightSprite;
    public Sprite leftSprite1;
    public Sprite leftSprite2;

    public Sprite rightSprite1;
    public Sprite rightSprite2;
    private SpriteRenderer spriteRenderer;
    private float turnTime;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update(){

        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        
        if(horizontal < 0){
            turnTime += Time.deltaTime;

            if(turnTime >= 0.1f){
                spriteRenderer.sprite = leftSprite2;
            }
            else{
                spriteRenderer.sprite = leftSprite1;
            }
        }
        else if(horizontal > 0){
            turnTime += Time.deltaTime;

            if(turnTime >= 0.1f){
                spriteRenderer.sprite = rightSprite2;
            }
            else{
                spriteRenderer.sprite = rightSprite1;
            }
        }
        else{
            turnTime = 0f;
            spriteRenderer.sprite = straightSprite;
        }

        transform.Translate(new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Asteroid")){
            Debug.Log("GAME OVER");
        }
    }

    void Shoot(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}