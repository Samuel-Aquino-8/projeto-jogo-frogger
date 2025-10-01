using UnityEngine;

public class Player_movement : MonoBehaviour
{
    float horizontal;
    public GameObject game_over;
    float vertical;
    public float move_speed;
    New_level NewLevel;

    public int Nivel_;

    void Start()
    {
        NewLevel = GameObject.FindGameObjectWithTag("Level").GetComponent<New_level>();
        Nivel_ = NewLevel.Nivel_atual;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Nivel_ != NewLevel.Nivel_atual)
        {
            transform.position = new Vector3(0, -4.5f, 0);
            Nivel_ = NewLevel.Nivel_atual;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Inimigo")
            {
            game_over.SetActive(true);
        }
        
    }

  
    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontal * move_speed * Time.deltaTime, vertical * move_speed * Time.deltaTime));
    }
}
