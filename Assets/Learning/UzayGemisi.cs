using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi
{
    /// <summary>
    /// Geminin maksimum hiz limiti
    /// </summary>
    int maksimumHiz;

    /// <summary>
    /// Geminin rengi
    /// </summary>
    string renk;

    /// <summary>
    /// Maksimum hiz degerini döner.
    /// </summary>
    public int MaksimumHiz
    {
        get
        {
            return maksimumHiz;
        }
    }

    /// <summary>
    /// Geminin renk değerini döner.
    /// </summary>
    public string Renk
    {
        get
        {
            return renk;
        }
    }

    /// <summary>
    /// Maksimum hiz ve rengi yazın.
    /// </summary>
    /// <param name="maksimumHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maksimumHiz, string renk = "Kirmizi")
    {
        this.maksimumHiz = maksimumHiz;
        this.renk = renk;
    }

    public UzayGemisi(int maksimumHiz)
    {
        this.maksimumHiz = maksimumHiz;
    }

    /// <summary>
    /// Uzay gemisini hizlandiran güc
    /// </summary>
    public void Hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }

    
    /// <summary>
    /// Uzay gemisini yavaşlatan güç
    /// </summary>
    
    public void Yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }
}
