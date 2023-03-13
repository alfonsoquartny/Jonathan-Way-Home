using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class SkillsTimeProgress : MonoBehaviour
{



    [SerializeField] Image skill1Image;
    [SerializeField] float skill1Speed;
   public float Skill1CurrentValue;
    public Button skill1;

    public TMP_Text timer;

    public float time;


    public GameObject[] destroys;


    public GameObject finalObjects;

    public AudioSource musicSource;
    private void Start()
    {
        timer.maxVisibleCharacters = 2;
        finalObjects.SetActive(false);

    }
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


    private void FixedUpdate()
    {
         time -= Time.deltaTime;
        timer.text = string.Format("{0:00}", time);



        if (time < 0)
        {
            LoseGame();
        }
    }


    public void LoseGame()
    {
        finalObjects.SetActive(true);
        musicSource.volume = 0.2f;

        int active =0;
        Destroy(destroys[0]);
        Destroy(destroys[1]);
        Destroy(destroys[2]);
        Destroy(destroys[3]);
        Destroy(destroys[4]);

    }


    public void toThisScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void exit()
    {
        Application.Quit();
    }
}
