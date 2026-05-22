using UnityEngine;

public class exit : MonoBehaviour
{
    public GameObject canvas;
    public void Exit()
    {
        canvas.SetActive(false);
    }
}

