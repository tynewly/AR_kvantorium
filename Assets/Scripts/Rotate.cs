using UnityEngine;

public class Rotate: MonoBehaviour
{
    public GameObject rotate_button;
    public void Start()
    {
      rotate_button.SetActive(false);
    }
    public GameObject objectToRotate;

    // Угол вращения за один клик
    public float rotationAngle = 45f;

    // Функция, которую вызовет кнопка
    public void RotateObject()
    {
        if (objectToRotate != null)
        {
            // Вращаем вокруг оси Y
            objectToRotate.transform.Rotate(rotationAngle, 0f, 0f);
        }
    }
} 
