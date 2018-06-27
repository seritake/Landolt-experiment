using UnityEngine;
using UnityEngine.UI;


public class ChangeColor : MonoBehaviour
{
    
    public void Start()
    {
        print("click");
        GetComponent<Image>().color = Color.red;
    }
}
