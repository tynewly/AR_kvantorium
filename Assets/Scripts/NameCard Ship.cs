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
        canvas.SetActive(false); 
        if (canvasGroup != null) // нету ли тут потворения в коде
        {
            canvasGroup.alpha = 0f;
        }
    }

    public void TargetFound()
    {
        canvas.SetActive(true);
        PlayCanvasAnimation();

    }

    void PlayCanvasAnimation()
    {
        if(canvasAnimation != null)
        {
            canvasAnimation.Play();
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
        if(canvasGroup != null) //зачем тут опять проверка
        {
            canvas.SetActive(false);
            //canvasGroup.alpha = 0f;
            //canvasGroup.interactable = false;
            //canvasGroup.blocksRaycasts = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
