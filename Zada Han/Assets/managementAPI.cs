using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using System.Threading.Tasks;


public class managementAPI : MonoBehaviour
{

    void InitializePlayGamesLogin()
    {
        PlayGamesPlatform.Instance.Authenticate();


        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }

    private void Start()
    {
        PlayGamesPlatform.Instance.Authenticate();

        LoginGoogle();


    }
    void LoginGoogle()
    {
        Social.localUser.Authenticate(OnGoogleLogin);
    }

    void OnGoogleLogin(bool success)
    {
        if (success)
        {
            // Call Unity Authentication SDK to sign in or link with Google.
            Debug.Log("Login with Google done. IdToken: " + ((PlayGamesLocalUser)Social.localUser).GetHashCode());
        }
        else
        {
            Debug.Log("Unsuccessful login");
        }
    }
}
