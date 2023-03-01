using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillsTimeProgress : MonoBehaviour
{



    [SerializeField] Image skill1Image;
    [SerializeField] float skill1Speed;
   public float Skill1CurrentValue;
    public Button skill1;


    void Update()
    {
        if (Skill1CurrentValue>0)
        {
            Skill1CurrentValue -= skill1Speed * Time.deltaTime;
        }


        skill1Image.fillAmount= Skill1CurrentValue/100;


        if (Skill1CurrentValue <= 0)
        {
            skill1.interactable = true;
        }
        else
        {
            skill1.interactable= false;
        }
    }
}
