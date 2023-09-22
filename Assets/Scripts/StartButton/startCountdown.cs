using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startCountdown : MonoBehaviour
{

    [SerializeField]
    private Text textCountdown;

    void Start()
    {
        textCountdown.text = "";
        StartCoroutine(CountdownCoroutine());
    }



    IEnumerator CountdownCoroutine()
    {
        textCountdown.gameObject.SetActive(true);

        textCountdown.text = "3";
        yield return new WaitForSeconds(1.0f);

        textCountdown.text = "2";
        yield return new WaitForSeconds(1.0f);

        textCountdown.text = "1";
        yield return new WaitForSeconds(1.0f);

        textCountdown.text = "GO!";
        yield return new WaitForSeconds(1.0f);

        textCountdown.text = "";
        textCountdown.gameObject.SetActive(false);

    }
}
