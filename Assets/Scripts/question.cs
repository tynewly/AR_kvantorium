using UnityEngine;
using UnityEngine.UI;
public class question : MonoBehaviour 
{
    public Button[] buttonWrong;
    public Button correctButton;
    private Color color;
    void Start()
    {

    }
    public void wrongAnswer()
    {
        color = Color.red;
        for (int i= 0; i < buttonWrong.Length; i++)
        {
            buttonWrong[i].GetComponent<Image>().color = color;
        }
    }
    public void correctAnswer()
    {
    color = Color.green;
    correctButton.GetComponent<Image>().color = color;

    }

    void Update()
    {
        
    }
}
