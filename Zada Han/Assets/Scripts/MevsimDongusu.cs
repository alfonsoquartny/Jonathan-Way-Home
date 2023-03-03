using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MevsimDongusu : MonoBehaviour
{

    public string AktifMevsim;

    public string[] mevsimler;

    public GameObject Sonbahar;
    public GameObject Winter;

    public Texture2D SonbaharTexture;
    public Texture2D SonbaharTextureNormal;

    public Texture2D WinterTexture;
    public Texture2D WinterTextureNormal;

    public float offsetY;


    public float speed;

    public Terrain terrain;
    void Start()
    {
        AktifMevsim = mevsimler[Random.Range(0, mevsimler.Length)];
        if (AktifMevsim == mevsimler[0])
        {
            Sonbahar.SetActive(true);
            Winter.SetActive(false);
            terrain.terrainData.terrainLayers[0].diffuseTexture = SonbaharTexture;
            terrain.terrainData.terrainLayers[0].normalMapTexture = SonbaharTextureNormal;

        }

        if (AktifMevsim == mevsimler[1])
        {
            Sonbahar.SetActive(false);
            Winter.SetActive(true);
            terrain.terrainData.terrainLayers[0].diffuseTexture = WinterTexture;
            terrain.terrainData.terrainLayers[0].normalMapTexture = WinterTextureNormal;


        }
        Debug.Log(AktifMevsim);
    }

    // Update is called once per frame
    void Update()
    {
        offsetY += Time.deltaTime*speed;
    }
    private void FixedUpdate()
    {
            terrain.terrainData.terrainLayers[0].tileOffset=new Vector2(0, offsetY);

    }
}
