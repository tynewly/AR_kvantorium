using UnityEngine;

public class ShowModel : MonoBehaviour
{
    public GameObject shop;
    public GameObject character;


    public void ShowDiorama()
    {
        shop.SetActive(true);
        character.SetActive(true);
    }
}
