using UnityEngine;

public class Rotate: MonoBehaviour
{
    public GameObject objectToRotate;

    // Угол вращения за один клик
    public float rotationAngle = 45f;

    // Функция, которую вызовет кнопка
    public void RotateObject()
    {
        if (objectToRotate != null)
        {
            // Вращаем вокруг оси Y
            objectToRotate.transform.Rotate(0f, rotationAngle, 0f);
        }
    }
} 
