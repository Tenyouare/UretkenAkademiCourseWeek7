using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kodlar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float enYuksek = PlayerPrefs.GetFloat("En Yuksek Skor");
        PlayerPrefs.SetFloat("En Yuksek Skor", 500);
        float enYuksekSkor = PlayerPrefs.GetFloat("En Yuksek" , 1000);
        //print("En Yuksek Skor : " + enYuksekSkor);  

        PlayerPrefs.SetInt("canSayisi", 10);
        //print(PlayerPrefs.GetInt("canSayisi",3));

        PlayerPrefs.SetString("oyuncuAdi", "Onur Torun");
        //print(PlayerPrefs.GetString("oyuncuAdi","oyuncu 1"));
        PlayerPrefs.DeleteKey("oyuncuAdi");
        print(PlayerPrefs.GetString("oyuncuAdi", "Oyuncu 1"));
        PlayerPrefs.DeleteAll();
        print( PlayerPrefs.GetFloat("En Yuksek", 999));
    }



}
