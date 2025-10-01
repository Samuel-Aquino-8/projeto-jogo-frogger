using UnityEngine;

public class Contador_level : MonoBehaviour
{
    New_level NewLevel;

    void Start()
    {
        NewLevel = GameObject.FindGameObjectWithTag("Level").GetComponent<New_level>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NewLevel.Nivel_atual += 1;
    }
    void Update()
    {
        
    }
}
