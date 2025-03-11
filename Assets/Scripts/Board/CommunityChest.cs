using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.UI;public  class CommunityChest : BoardLocation {    public GameObject akiado;    public GameObject bluefacemeghivott;    public GameObject dobjegy;
    public GameObject felpofoztalegy;
    public GameObject fizess1000;
    public GameObject gratulalunkaz;
    public GameObject labonlottek;
    public GameObject lemezeideladasabol;
    public GameObject meghuztada;
    public GameObject megkaptada;
    public GameObject ramozdultalbhad;
    public GameObject resztvettel;
    public GameObject utazzcleveland;
    public GameObject xmeghalt;        public override void PassBy(Player player)    {        Debug.Log("Passed by community chest");    }
    
    private int randomszam;    public override IEnumerator LandOn(Player player)    {

        randomszam = Random.Range(0, 13);
        switch (randomszam)
        {
            case 0:
                {
                    akiado.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(1000);
                    akiado.SetActive(false);
                    break;
                    
                }
            case 1:
                {
                    bluefacemeghivott.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(2500);
                    bluefacemeghivott.SetActive(false);
                    break;
                    

                }
            case 2:
                {
                    felpofoztalegy.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(-5000);
                    felpofoztalegy.SetActive(false);
                    break;
                }
            case 3:
                {
                    gratulalunkaz.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(20000);                    
                    gratulalunkaz.SetActive(false);
                    break;
                }
            case 4:
                {
                    lemezeideladasabol.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(5000);
                    lemezeideladasabol.SetActive(false);
                    break;
                }
            case 5:
                {
                    meghuztada.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(-5000);
                    meghuztada.SetActive(false);
                    break;
                } 
            case 6:
                {
                    ramozdultalbhad.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(InJail.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    ramozdultalbhad.SetActive(false);
                    break;
                } 
            case 7:
                {
                    labonlottek.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(-10000);
                    labonlottek.SetActive(false);
                    yield return player.JumpToSpace(FreeParking.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    break;
                }
            case 8:
                {
                    utazzcleveland.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(Cleveland.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    utazzcleveland.SetActive(false);                   
                    break;
                }
            case 9:
                {
                    xmeghalt.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(10000);
                    xmeghalt.SetActive(false);
                    break;
                    
                }
            case 10:
                {
                    resztvettel.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(2000);
                    resztvettel.SetActive(false);
                    break;
                }
            case 11:
                {
                    megkaptada.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(10000);
                    megkaptada.SetActive(false);
                    break;
                }
            case 12:
                {
                    dobjegy.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    dobjegy.SetActive(false);
                    yield return player.JumpToSpace(Start.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    break;
                }
          /*  case 0:
                {
                    fizess1000.SetActive(true);
                    fizess1000.SetActive(false);
                    break;
                                  
                }
                /* case 14:
                     {
                         megérekezet a buliba a diler gyüjtsbe midnekitöl $1000
                         break;
                     }
                 case 15:
                     {
                         ingyen szabadulsz a börtönből
                         break;
                     } */

        }








    }}