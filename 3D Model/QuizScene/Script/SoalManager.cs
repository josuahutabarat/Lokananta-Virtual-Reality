using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoalManager : MonoBehaviour
{
    [System.Serializable]
    public class Soal
    {
        [TextArea]
        [Header("Soal")]
        public string soal;

        [Header("Pilihan untuk jawaban")]
        public string pilA;
        public string pilB, pilC, pilD;

        [Header("Kunci Jawaban")]
        public bool A;
        public bool B, C, D;

    }

    public GameObject selesai;
    public int skor;
    public float waktu;
    private int nilaAcak;
    Text textSoal, textA, textB, textC, textD, textWaktu;
    public List<Soal> KumpulanSoal;
    // Start is called before the first frame update
    void Start()
    {
        textSoal = GameObject.Find("TextSoal").GetComponent<Text>();
        textA = GameObject.Find("A").GetComponent<Text>();
        textB = GameObject.Find("B").GetComponent<Text>();
        textC = GameObject.Find("C").GetComponent<Text>();
        textD = GameObject.Find("D").GetComponent<Text>();

        textWaktu = GameObject.Find("TextWaktu").GetComponent<Text>();

        nilaAcak = Random.RandomRange(0, KumpulanSoal.Count);
       
    }

    // Update is called once per frame
    void Update()
    {
        textWaktu.text = "Time : " + waktu.ToString("0.0");
        waktu -= Time.deltaTime;
        if (waktu <= 0)
        {
            KumpulanSoal.RemoveAt(nilaAcak);
            waktu = 10;
            nilaAcak = Random.RandomRange(0, KumpulanSoal.Count);
        }

        if (KumpulanSoal.Count > 0)
        {
            textSoal.text = KumpulanSoal[nilaAcak].soal;
            textA.text = KumpulanSoal[nilaAcak].pilA;
            textB.text = KumpulanSoal[nilaAcak].pilB;
            textC.text = KumpulanSoal[nilaAcak].pilC;
            textD.text = KumpulanSoal[nilaAcak].pilD;
        }
        else
        {
            selesai.SetActive(true);
            textSoal.text = "Skor Anda : " + skor;
            GameObject.Find("TextWaktu").SetActive(false);
            GameObject.Find("Panel").SetActive(false);
        }
        
    }

    public void CekJawaban(string jawaban)
    {
        if (KumpulanSoal[nilaAcak].A==true && jawaban=="a")
        {
            skor++;
        }

        if (KumpulanSoal[nilaAcak].B == true && jawaban == "b")
        {
            skor++;
        }

        if (KumpulanSoal[nilaAcak].C == true && jawaban == "c")
        {
            skor++;
        }

        if (KumpulanSoal[nilaAcak].D == true && jawaban == "d")
        {
            skor++;
        }

        KumpulanSoal.RemoveAt(nilaAcak);
        nilaAcak = Random.RandomRange(0, KumpulanSoal.Count);
        waktu = 10;
    }

    public void ulang()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
