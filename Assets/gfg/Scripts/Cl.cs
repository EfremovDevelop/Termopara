using UnityEngine;
using UnityEngine.EventSystems;
public class Cl : MonoBehaviour, IPointerClickHandler
{
    //bool isPacked = true;
    private Animator anim; // 

    public Termopara Parent; // Это термоара  
    
    public void OnPointerClick(PointerEventData eventData) //получаем события нажатия
    {
       
        if (!Parent.isPacked) // если не открыта термопара
        {
            anim.Play("Open1"); // открываем, то есть включаем анимацию
            Debug.Log("Привет, я открылся!"); // пишем в консоли, что открыли для удобства
            Parent.isPacked = true; // записываем в свойство термопары, что Термопара открыта
        }
        else // иначе (если открыта термпопара
        {
            anim.Play("Close"); // закрываем термопару  
            Debug.Log("Привет, я закрылся!"); // пишем в консоли, что закрыли для удобства
            Parent.isPacked = false; // записываем в свойство термопары, что Термопара закрыта 
        }
    }

    void Start()
    {
        anim = GetComponent<Animator>(); // получаем компонент Animator 
    }

    //Update is called once per frame
    void Update()
    {

    }  
}
