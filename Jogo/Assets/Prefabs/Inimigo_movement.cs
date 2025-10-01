using UnityEngine;

public class Inimigo_movement : MonoBehaviour
{
    float speed;
    public float speed_direction;
    New_level NewLevel;

    void Start()
    {
        NewLevel = GameObject.FindGameObjectWithTag("Level").GetComponent<New_level>();
        Destroy(this.gameObject, 10);
    }


    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        speed = ((NewLevel.Nivel_atual * 0.25f) + 3) * speed_direction;
    }
}
