using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenSample : MonoBehaviour
{
    //[SerializeField] Ease tipimiz;
    [SerializeField] GameObject player;


    void Start()
    {
        player.transform.DOMoveZ(100f, 15f);
        Sequence seq = DOTween.Sequence();

        #region Part1
        //initialize etmek
        //DOTween.Init();
        //transform.DOMoveZ(5f,4f).OnStart(Started).OnComplete(Finished); //kill

        //Using Lambda expression
        //transform.DOMoveZ(5f, 4f).OnComplete(() =>
        //{
        //    Debug.Log("Finished");
        //    Debug.Log("Finished");
        //    Debug.Log("Finished");
        //});
        #endregion

        #region IshlemeArdicilligiNumune1
        //Tween ishleme ardicilligi numune 1
        //transform.DOMoveZ(5f, 2f).OnComplete(() =>
        //{
        //    transform.DOMoveX(-5f, 1f).OnComplete(() =>
        //    {
        //        transform.DOMoveZ(transform.position.z + 5f, 2f);
        //    });
        //});
        #endregion

        #region ishlemeArdiciliigiNumune2
        //Tween ishleme ardicilligi numune 2
        //seq.Append(transform.DOMoveZ(5f, 1f)).Append(transform.DOMoveX(5f, 1f));

        //Tween ishleme ardicilligi numune 3 | Her 3 numune de eyni ishi icra edir.
        //seq.Append(transform.DOMoveX(5f, 1f
        //seq.Append(transform.DOMoveX(5f, 1f));
        #endregion

        #region IshlemeArdicilligiNumune3
        //transform.DOMoveX(-5f, 1f);
        //transform.DOMoveX(-5f, 1f);
        #endregion

        #region SequenceArdicilligi
        //Join Numunesi | Tweenlerin eyni anda ishlemesi
        //seq.Append(transform.DOMoveZ(15f, 2f)).Join(transform.DOMoveX(10f,2f));

        //Insert Numunesi |  Tweenlerin verdiyimiz zamana gore ishlemesi
        //seq.Append(transform.DOMoveZ(5f, 2f)).Insert(4f,transform.DOMoveX(10f, 2f));
        #endregion


        transform.DOScale(2f, 1f).SetLoops(-1,LoopType.Yoyo);

    }

    void Started()
    {
        Debug.Log("Started");
    }

    void Finished()
    {
        Debug.Log("Finished");
    }

    private void Update()
    {
        #region RunnerController
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.DOMoveX(transform.position.x - 3f, .8f);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.DOMoveX(transform.position.x + 3f, .8f);
        //}
        #endregion
        //transform.DOMoveZ(10f, 2f).SetEase(tipimiz);
    }

}
