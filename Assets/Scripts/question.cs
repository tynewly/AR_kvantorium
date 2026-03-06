using UnityEngine;
using UnityEngine.UI;
public class question : MonoBehaviour 
{
    public Button[] buttonWrong;
    public Button correctButton;
    public GameObject win;
    public GameObject lose;
    private Color color;
    public float time = 30;
    private bool answer = false;
  



    void Start()
    {
        win.SetActive(false);
        lose.SetActive(false);
      

    }
    public void timeAnswer()
    {
        if (answer == false)
        {
            time = time - Time.deltaTime;
            if (time < 0)
            {
                wrongAnswer();

            }

            Debug.Log(time);
        }
            

        
    }    
    public void wrongAnswer()
    {
        color = Color.red;
        for (int i= 0; i < buttonWrong.Length; i++)
        {
            buttonWrong[i].GetComponent<Image>().color = color;

        }
        correctButton.GetComponent<Image>().color = Color.green;
        lose.SetActive(true);
        answer = true;
    }
    public void correctAnswer()
    {
    color = Color.green;
    correctButton.GetComponent<Image>().color = color;
        for (int i = 0; i < buttonWrong.Length; i++)
        {
            buttonWrong[i].GetComponent<Image>().color = Color.red;
        }
        win.SetActive(true);
        answer = true;

    }

    void FixedUpdate()
    {
        timeAnswer();
    }
}
