using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private string[] normal_character; //Список персонажей
    [SerializeField] private string[] rare_character; //Список персонажей
     [SerializeField] private string[] more_rare_character; //Список персонажей
     [SerializeField] private string[] epic_character; //Список персонажей
     [SerializeField] private string[] legedary_character; //Список персонажей
     [SerializeField] private int chance; // Вероятность выпадения
     private int rare_Item = 300;
     private int more_rareItem = 200;
     private int epic_Item = 100;
     private int legendary_Item = 50;
     public void OpenBox()
     {
         
         chance = Random.Range(0, 600);
         if (chance <= rare_Item){
             ;
         }

        if (chance <= more_rareItem){
             ;
        }
        if (chance <= epic_Item){
             ;
        }
        
        else;{
            ;
        }

     }
    
}
