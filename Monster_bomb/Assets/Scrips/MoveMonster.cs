using System.Security.Cryptography;
using UnityEngine;

public class MoveMonster : MonoBehaviour
{
    public Transform monster; // переменная типа трансформ (игрок)
    [SerializeField] // свойство для того что прайвет виднелся в юнити
    private float speed = 10f; //переменная скорости

    void OnMouseDrag() // функция нажатия мышки и движение по объекту
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // переменная 
        mousePos.x = mousePos.x > 2f ? 2f : mousePos.x; // проверка(если переменная больше то устанавление лимита)
        mousePos.x = mousePos.x < -2f ? -2f : mousePos.x;
        monster.position = Vector2.MoveTowards(monster.position, 
            new Vector2(mousePos.x, monster.position.y),
            speed * Time.deltaTime); // позиция игрока движение по горизонтали
    }
}
