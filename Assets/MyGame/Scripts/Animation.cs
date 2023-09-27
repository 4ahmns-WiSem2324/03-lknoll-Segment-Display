using System.Collections;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject[] segmente;
    
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            StartCoroutine(Anim());
        }
    }
    IEnumerator Anim()
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

        yield return new WaitForSeconds(0.5f);
        segmente[11].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[7].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[12].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[8].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[10].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[13].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[9].SetActive(true);

        yield return new WaitForSeconds(0.5f);
        segmente[18].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[14].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[19].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[15].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[17].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[20].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[16].SetActive(true);

        yield return new WaitForSeconds(0.5f);
        segmente[25].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[21].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[26].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[22].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[24].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[27].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        segmente[23].SetActive(true);

        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < segmente.Length; i++)
        {
            segmente[i].SetActive(false);
        }
    }
}
