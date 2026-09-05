using Unity.VisualScripting;
using UnityEngine;

public class NameCard : MonoBehaviour
{
    [Header("Настройки")]
    public CanvasGroup canvasGroup;
    public Animation canvasAnimation;
    public GameObject canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //canvas.SetActive(false); 
        if (canvasGroup != null) // нету ли тут повторения в коде
        {
            canvasGroup.alpha = 0f;
        }
        Debug.Log("появился");
    }

    public void TargetFound()
    {
        //canvas.SetActive(true);
        PlayCanvasAnimation();
        Debug.Log("таргет найден");
    }

    void PlayCanvasAnimation()
    {
        if(canvasAnimation != null)
        {
            canvasAnimation.Play();
            Debug.Log("анимация");
            Invoke("EnableInteractions", 2f);
            
        }
    }

    void EnableInteractions()
    {
        if(canvasGroup != null)
        {
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }
    }

    public void HideCanvas()
    {
        if(canvasGroup != null) //& (canvasGroup.alpha == 1f)//зачем тут опять проверка
        {
            canvas.SetActive(false);
            //canvasGroup.alpha = 0f;
            //canvasGroup.interactable = false;
            //canvasGroup.blocksRaycasts = false;
            Debug.Log("спрятался");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TargetFound();
    }
}
