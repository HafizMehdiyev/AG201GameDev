using CASP.SoundManager;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class VolumeController : MonoBehaviour
{
    [Header("Adimiz")]
    public string name;

    public Slider volumeSlider;
    private AudioSource audioSrc;
    public AudioClip AtdigimClip;
    public Text volumeText;
    


    void Start()
    {

        audioSrc = GetComponent<AudioSource>();


        //scripte atdigimiz klipi audio source komponentinin klipine teyin edirik.
        //audioSrc.clip = AtdigimClip;

        //audio Source komponentine atdigimiz ses faylini play edirik.
        //audioSrc.Play();

        //audio source-un ses yuksekliyini 1 teyin edirik.
        //audioSrc.volume = 1f;

        //verdiyimiz sliderin deyerini 1 edirik. Cunki sliderin default deyeri 0dir.
        //biz ise sliderin deyerini audio source komponentinin ses yukseklik deyerine teyin etmishik.
        //slider 0 olsaydi oyun bashlayanda sesimizin yuksekliyi de 0 olardi.Ona gore de startda
        //sliderimizi 1 edirik.
        volumeSlider.value = 1;
    }

    //VolumeSet methodumuzu sliderin On Changed Eventinde cagirmishiq. biz her slidere toxunduqda
    //ve deyerini deyishdikde bu zaman VolumeSet Methodu ishe dusher.
    public void VolumeSet()
    {
        //ekrana ses yuksekliyimizin deyerini chap edirik.
        volumeText.text = volumeSlider.value.ToString("0");
        //audioSrc.volume = volumeSlider.value;
        
        //Audio Listener bizim oyunumuzun umumi dinleyici komponentidir. Biz Listenerin
        //deyerini azaltsaq bu zaman oyundaki butun seslerin ses seviyyesi azalar.
        AudioListener.volume =volumeSlider.value;
        Debug.LogWarning("Deyishdi");
    }
    public void PlaySound()
    {
        //sesi bashladir.
        audioSrc.Play();
    }
    
    
    public void PauseSound()
    {
        StartCoroutine(PauseSoundTimer());
    }

    IEnumerator PauseSoundTimer()
    {
        yield return new WaitForSeconds(1f);
        audioSrc.Pause(); //sesi pause edir.
    }
}

