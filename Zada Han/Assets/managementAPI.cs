using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using System.Threading.Tasks;


public class managementAPI : MonoBehaviour
{
 
    void Start()
    {
        Social.localUser.Authenticate((bool success) => {
            // handle success or failure
        });

    }

    // Update is called once per frame
    void Update()   
    {
        
    }
}
