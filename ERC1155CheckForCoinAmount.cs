using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nethereum.JsonRpc.UnityClient;
using System.Numerics;
using ERC1155.Contracts.ERC1155.ContractDefinition;
using System;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using TMPro.EditorUtilities;
using UnityEngine.Rendering;
using Nethereum.Web3;

public class ERC1155CheckForCoinAmount : MonoBehaviour
{
    public string infuriaUrl = "";
    public string userWallet = "";
    public int rariIdOfCoin;
    public string contractOfCoin = "";

    public BigInteger numberOfCoinsUserHas;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(FetchCoinInformation());
    }

    private IEnumerator FetchCoinInformation()
    {
        // Create the queryRequest to the BalanceOfFunction of the 1155 coin
        var queryRequest = new QueryUnityRequest<BalanceOfFunction, BalanceOfOutputDTO>(infuriaUrl, userWallet);

        // BigInteger Rari ID of the coin we are looking for (Aqua Mars)
        var rarID = new BigInteger(rariIdOfCoin);

        //Send the account and Rari ID to the BalanceOfFunction, also send along the contract address of the Aqua Mars Coin
        yield return queryRequest.Query(new BalanceOfFunction() { Account = userWallet, Id = rariIdOfCoin }, contractOfCoin);

        numberOfCoinsUserHas = queryRequest.Result.ReturnValue1;

    }
}
