using UnityEngine;
using TMPro;

public class quest1 : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Canvas_quest;
    public GameObject Canvas_quiz;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Canvas_quest.SetActive(false);
        Canvas_quiz.SetActive(false);
    }

    public void correctTarget()
    {
        Canvas_quest.SetActive(true);
    }

    public void button1()
    {
        Text.text = "Вы испугались и решили откупиться. Отдайте 1 любую единицу товара";
    }

    public void button2()
    {
        Text.text = "Вы не повелись на провокации. Бросьте кубик, он определит исход драки";
    }

    public void button3()
    {
        Text.text = "Противники оказались слишком сильны, вернитесь на 2 шага назад";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
