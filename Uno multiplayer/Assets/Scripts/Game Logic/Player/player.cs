using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class player : NetworkBehaviour
{
    UnoCards unoCardsDataSet;
    private void Start()
    {
        if(!IsOwner) return;
        unoCardsDataSet = new UnoCards(); 
        unoCardsDataSet.InitializeDictionary();
    }
    private void Update()
    {
        
    }
}
