using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chance : BoardLocation 
{

    public GameObject agyereked;
    public GameObject atesoiddal;
    public GameObject gratulalunkosszetorted;
    public GameObject illegalisfegyvertartas;
    public GameObject megnyertelegy;
    public GameObject nagyotmegy;
    public GameObject bunosnektalaltak;
    public GameObject fejbelottek;
    public GameObject menja;
    public GameObject repuljel;
    public GameObject utazzatlantaba;
    public GameObject utazzhaza;
    public GameObject utazzphiladelphiaba;
    public GameObject ittasvezetesert;
    public GameObject azalbumod;


    public override void PassBy(Player player)
    {
        Debug.Log("Passed by Chance");
    }

    private int randomszam;    public override IEnumerator LandOn(Player player)    {

        randomszam = Random.Range(0, 15);
        switch (randomszam)
        {
            case 0:
                {
                    agyereked.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(-15000);
                    agyereked.SetActive(false);
                    break;
                }
            case 1:
                {
                    atesoiddal.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(5000);
                    atesoiddal.SetActive(false);
                    break;
                }
            case 2:
                {
                    gratulalunkosszetorted.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(-15000);
                    gratulalunkosszetorted.SetActive(false);
                    break;
                }
            case 3:
                {
                    illegalisfegyvertartas.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(-20000);
                    illegalisfegyvertartas.SetActive(false);
                    break;
                }
            case 4:
                {
                    megnyertelegy.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(10000);
                    megnyertelegy.SetActive(false);
                    break;
                }
            case 5:
                {
                    nagyotmegy.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(15000);
                    nagyotmegy.SetActive(false);
                    break;
                }
            case 6:
                {
                    bunosnektalaltak.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(InJail.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    bunosnektalaltak.SetActive(false);
                    break;
                }
            case 7:
                {
                    fejbelottek.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(FreeParking.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    fejbelottek.SetActive(false);
                    break;
                }
            case 8:
                {
                    menja.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(CashMoneyRecords.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    menja.SetActive(false);
                    break;
                }
            case 9:
                {
                    repuljel.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(Toronto.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    repuljel.SetActive(false);
                    break;
                }
            case 10:
                {
                    utazzatlantaba.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(Atlanta.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    utazzatlantaba.SetActive(false);
                    break;
                }
            case 11:
                {
                    utazzhaza.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(Start.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    utazzhaza.SetActive(false);
                    break;
                }
            case 12:
                {
                    utazzphiladelphiaba.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.JumpToSpace(Philadelphia.instance, 2f);
                    yield return player.RotateAdditionalDegrees(180, 1f);
                    utazzphiladelphiaba.SetActive(false);
                    break;
                }
            case 13:
                {
                    ittasvezetesert.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    player.AdjustBalanceBy(-1500);
                    ittasvezetesert.SetActive(false);
                    break;
                }
            case 14:
                {
                    azalbumod.SetActive(true);
                    yield return MessageAlert.instance.DisplayAlert("", Color.red);
                    yield return player.MoveSpaces(-3);
                    azalbumod.SetActive(false);
                    break;
                }
                /*  case 15:
                      {
                          ingyen szabadulsz a börtönből
                          break;
                      } */

        }








    }
}
