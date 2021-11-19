using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawab : MonoBehaviour
{

    public float waktu;
    Text textWaktu;
    public GameObject feed_benar, feed_salah;

    // Start is called before the first frame update
    void Start()
    {
        textWaktu = GameObject.Find("TextWaktu1").GetComponent<Text>();
    }

    public void jawaban(bool jawab)
    {
        if (jawab)
        {
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
            int skor = PlayerPrefs.GetInt("skor")+20;
            PlayerPrefs.SetInt("skor", skor);
        }
        else
        {
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
        }
        gameObject.SetActive (false);
        transform.parent.GetChild (gameObject.transform.GetSiblingIndex () + 1).gameObject.SetActive (true);
    }

    // Update is called once per frame
    void Update()
    {
        textWaktu.text = "Sisa Waktu : " + waktu.ToString("0.0");
        waktu -= Time.deltaTime;
        if (waktu <= 0)
        {
            gameObject.SetActive(false);
            transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
            waktu = 10;
        }
    }

    public void ulang()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
