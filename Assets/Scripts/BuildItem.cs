﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

[CreateAssetMenu(fileName = "ItemBuildObject", menuName = "Inventory/Create ItemBuildObject")]
public class BuildItem : Item
{

    public GameObject prafabToBuild;
    public GameObject buildModel;
    BuildSystem BS;

    

    public override void Use()
    {
        BS = GameObject.FindGameObjectWithTag("PlayerHand").GetComponent<BuildSystem>();
        if (BS != null)
        {

            BS.setBuild(this.prafabToBuild, this.buildModel);
         
        }
          
        else Debug.Log("Nie znalezion Build System");
    }
    public override void UnUse()
    {
        BS = GameObject.FindGameObjectWithTag("PlayerHand").GetComponent<BuildSystem>();
        if (BS != null)
        {
                     
        }
        else Debug.Log("Nie znalezion Build System");
    }
   

    //Dodana funckja
    public override string GetInfo(bool isMainInventory=true)
    {
        if (isMainInventory)
        {
            string information = string.Empty;
            Tower tower = prafabToBuild.transform.GetChild(0).GetComponent<Tower>();
            information = string.Format("<size=14>{0}\n</size><size=12><color=green>MONEY: {1}$</color>\n<color=yellow>GOLD: {2}</color>\n<color=silver>SILVER: {3}</color>\n<color=brown>BRONZE: {4}</color>\n<color=red>DAMAGE: {5}</color></size>", tower.NameItem, tower.Money, tower.Gold, tower.Silver, tower.Bronze, tower.MyRange.Damge);
            return information;
        }
        else
        {
            string information = string.Empty;
            Tower tower = prafabToBuild.transform.GetChild(0).GetComponent<Tower>();
            //information = "asdasfdsfdsfd";
            information = string.Format("<size=14>{0}\n</size><size=12><color=green>{1} $MONEY</color>\n<color=yellow>{2} GOLD</color>\n<color=silver>{3} SILVER</color>\n<color=brown>{4} BRONZE</color>\n<color=red>{5} DAMAGE</color></size>", tower.NameItem, tower.Money, tower.Gold, tower.Silver, tower.Bronze, tower.MyRange.Damge);
            return information;
        }
        
    }

}
