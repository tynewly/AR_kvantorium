using UnityEngine;

public class hideScript : MonoBehaviour
{
    public GameObject[] hideQuestion;
    public GameObject rotate;
    public GameObject question;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < hideQuestion.Length; i++)
        {
            hideQuestion[i].SetActive(false);
        }
        question.SetActive(false);
    }

    public void openQuiz()
    {
        for (int i = 0; i < hideQuestion.Length; i++)
        {
            hideQuestion[i].SetActive(true);
        }
        gameObject.SetActive(false);
        rotate.SetActive(false);
        question.SetActive(true);
        
    }
}
