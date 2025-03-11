using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ownable : BoardLocation
{   
    protected Player owner;
    [SerializeField] public GameObject haz1;
    [SerializeField] public GameObject haz2;
    [SerializeField] public GameObject haz3;
    [SerializeField] public GameObject haz4;
    [SerializeField] public GameObject haz5;
    [SerializeField] private string propertyName;
    [SerializeField] private int purchasePrice;
    [SerializeField] private int mortgageValue;
    [SerializeField] public Sprite deed;
    [SerializeField] public GameObject kartya;
    [SerializeField] public Property p;


    public sealed override void PassBy(Player player)
    {}

    public sealed override IEnumerator LandOn(Player player)
    {
        if (owner == null)
        {
            if (!player.IsAI())
            {
                yield return LerpCameraViewToThisLocation();
                yield return OwnablePurchaseDialog.instance.OfferPurchase(this);

                if (OwnablePurchaseDialog.instance.resultingDecision)
                {
                    player.AdjustBalanceBy(-purchasePrice);
                    player.currentOwnables.Add(this);
                    owner = player;
                    kartya.gameObject.SetActive(false);
                }

                yield return LerpCameraViewBackToMainBoardView();
            }
            else
            {
                // AI 
                player.AdjustBalanceBy(-purchasePrice);
                player.currentOwnables.Add(this);
                owner = player;
                kartya.gameObject.SetActive(false);
            }
        }
        else
        {
            if (owner != player)
            {
                int toCharge = ChargePlayer();
                player.AdjustBalanceBy(-toCharge);
                owner.AdjustBalanceBy(toCharge);
            }else 
            {
                yield return LerpCameraViewToThisLocation();
                yield return BuildDialog.instance.OfferBuild(this);
               if (BuildDialog.instance.resultingDecisionBuild)
                {
                    int hazvetele = hazmegvetele();

                    switch (BuildDialog.instance.mennyihaz)
                    {
                        case 1:
                            {
                                haz1.gameObject.SetActive(true);
                                p.currentUpgradeLevel++;
                                player.AdjustBalanceBy(-hazvetele);
                                break;

                            }
                        case 2:
                            {
                                haz1.gameObject.SetActive(true);
                                haz2.gameObject.SetActive(true);
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                break;

                            }
                        case 3:
                            {
                                haz1.gameObject.SetActive(true);
                                haz2.gameObject.SetActive(true);
                                haz3.gameObject.SetActive(true);
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                break;

                            }
                        case 4:
                            {
                                haz1.gameObject.SetActive(true);
                                haz2.gameObject.SetActive(true);
                                haz3.gameObject.SetActive(true);
                                haz4.gameObject.SetActive(true);
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                break;

                            }
                        case 5:
                            {
                                haz1.gameObject.SetActive(true);
                                haz2.gameObject.SetActive(true);
                                haz3.gameObject.SetActive(true);
                                haz4.gameObject.SetActive(true);
                                haz5.gameObject.SetActive(true);
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                p.currentUpgradeLevel++;
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                player.AdjustBalanceBy(-hazvetele);
                                break;

                            }
                    }
                } 

                yield return LerpCameraViewBackToMainBoardView();
            }
        }
    }
    
    protected abstract int ChargePlayer();
    protected abstract int hazmegvetele();

    
    
}
