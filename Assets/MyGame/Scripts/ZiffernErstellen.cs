using System.Collections;
using UnityEngine;

public class ZiffernErstellen : MonoBehaviour
{
    public GameObject[] segmente;
    
    void Update()
    {
        if (Input.GetKeyDown("0"))
        {
            EnableAllSegments();
            segmente[0].SetActive(true);
            segmente[2].SetActive(true);
            segmente[3].SetActive(true);
            segmente[4].SetActive(true);
            segmente[5].SetActive(true);
            segmente[6].SetActive(true);
        }
        if (Input.GetKeyDown("1"))
        {
            EnableAllSegments();
            segmente[5].SetActive(true);
            segmente[6].SetActive(true);
        }
        if (Input.GetKeyDown("2"))
        {
            EnableAllSegments();
            segmente[0].SetActive(true);
            segmente[1].SetActive(true);
            segmente[2].SetActive(true);
            segmente[3].SetActive(true);
            segmente[5].SetActive(true);
        }
        if (Input.GetKeyDown("3"))
        {
            EnableAllSegments();
            segmente[0].SetActive(true);
            segmente[1].SetActive(true);
            segmente[2].SetActive(true);
            segmente[5].SetActive(true);
            segmente[6].SetActive(true);
        }
        if (Input.GetKeyDown("4"))
        {
            EnableAllSegments();
            segmente[1].SetActive(true);
            segmente[4].SetActive(true);
            segmente[5].SetActive(true);
            segmente[6].SetActive(true);
        }
        if (Input.GetKeyDown("5"))
        {
            EnableAllSegments();
            segmente[0].SetActive(true);
            segmente[1].SetActive(true);
            segmente[2].SetActive(true);
            segmente[4].SetActive(true);
            segmente[6].SetActive(true);
        }
        if (Input.GetKeyDown("6"))
        {
            EnableAllSegments();
            segmente[0].SetActive(true);
            segmente[1].SetActive(true);
            segmente[2].SetActive(true);
            segmente[3].SetActive(true);
            segmente[4].SetActive(true);
            segmente[6].SetActive(true);
        }
        if (Input.GetKeyDown("7"))
        {
            EnableAllSegments();
            segmente[0].SetActive(true);
            segmente[5].SetActive(true);
            segmente[6].SetActive(true);
        }
        if (Input.GetKeyDown("8"))
        {
            for (int i = 0; i < segmente.Length; i++)
            {
                segmente[i].SetActive(true);
            }
        }
        if (Input.GetKeyDown("9"))
        {
            EnableAllSegments();
            segmente[0].SetActive(true);
            segmente[1].SetActive(true);
            segmente[2].SetActive(true);
            segmente[4].SetActive(true);
            segmente[5].SetActive(true);
            segmente[6].SetActive(true);
        }
        if (Input.GetKeyDown("space"))
        {
            EnableAllSegments();
            StartCoroutine(Animation());
        }
    }
    void EnableAllSegments()
    {
        for (int i = 0; i < segmente.Length; i++)
        {
            segmente[i].SetActive(false);
        }
    }
    IEnumerator Animation()
    {
        segmente[4].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[0].SetActive(true); 
        yield return new WaitForSeconds(0.5f);
        segmente[5].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[3].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[6].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[2].SetActive(true);
    }
}
