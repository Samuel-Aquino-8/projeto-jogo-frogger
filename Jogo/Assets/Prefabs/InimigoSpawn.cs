using UnityEngine;

public class InimigoSpawn : MonoBehaviour
{
    float cool_down = 2;
    public GameObject inimigoD;
    public GameObject inimigoE;
    void Start()
    {
    }


    void Update()
    {
        if (cool_down <= 0)
        {
            Instantiate(inimigoD, new Vector3(Random.Range(10, 16), 0, 0), Quaternion.identity);
            Instantiate(inimigoE, new Vector3( Random.Range(-16, -10),0, 0), Quaternion.identity);
            cool_down = 2;
        }
        else
        {
            cool_down -= Time.deltaTime;
        }
    }
}
