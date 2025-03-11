using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuildDialog : MonoBehaviour
{
    public static BuildDialog instance;

    void Awake()
    {
        instance = this;
    }
    public TMP_Text hazszam;

    void Update()
    {
        hazszam.text = mennyihaz.ToString();
    }
    

    public int mennyihaz = 0;

    


    public void pluszegyhaz()
    {
        mennyihaz++;
        if (mennyihaz >5)
        {
            mennyihaz = 0;
        }
    }
    public void minuszegyhaz()
    {
        mennyihaz--;
        if (mennyihaz < 0)
        {
            mennyihaz = 0;
        }
    }
    

    [SerializeField] private Image deedImage;

   [HideInInspector] public bool decisionMade, resultingDecisionBuild;

    

    public IEnumerator OfferBuild(Ownable ownable)
    {
        decisionMade = false;


        deedImage.sprite = ownable.deed;
        transform.GetChild(0).gameObject.SetActive(true);

        

        while (!decisionMade)
            yield return null;

        transform.GetChild(0).gameObject.SetActive(false);
    }


    public void Buy()
    {

        resultingDecisionBuild = true;
        decisionMade = true;


    }



    public void Nothing()
    {
        resultingDecisionBuild = false;
        decisionMade = true;
    }
}
