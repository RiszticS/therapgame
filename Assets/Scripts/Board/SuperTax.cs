using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperTax : BoardLocation 
{
    public override void PassBy(Player player)
    {
    }

    public override IEnumerator LandOn(Player player)
    {
        yield return MessageAlert.instance.DisplayAlert("Gyerektartás! Fizess $10 000-t!", Color.red);
        player.AdjustBalanceBy(-10000);
    }
}
