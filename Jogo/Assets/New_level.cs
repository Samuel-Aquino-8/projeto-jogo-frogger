using UnityEngine;
using UnityEngine.UI;

public class New_level : MonoBehaviour
{
    public Text contador_;
    public int Nivel_atual;
    void Start()
    {
    }

    
    void Update()
    {
        contador_.text = "Nível: " + Nivel_atual.ToString();
    }
    
}
