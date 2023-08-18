using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using System.Threading.Tasks;
using WalletConnectSharp.Core.Models;

public class loginScreen : MonoBehaviour
{
    private ThirdwebSDK sdk;
    public GameObject walletConnection;

    void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(walletConnection);

        sdk = new ThirdwebSDK("polygon");
        //Debug.Log(sdk.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async Task<string> getBalance(string address)
    {
        Contract contract = sdk.GetContract("0x645CDCf725Fd1B99A021C9ce89429f2D434708cD");
        string balance = await contract.Read<string>("balanceOf", address, 0);

        return balance;


    }

    public void toggleLoginScreen(GameObject connectedState, GameObject disconnectedState)
    {

        string balance = getBalance("0x645CDCf725Fd1B99A021C9ce89429f2D434708cD").ToString();

        connectedState.SetActive(!connectedState.activeSelf);
        disconnectedState.SetActive(!connectedState.activeSelf);
        connectedState.GetComponentInChildren<UnityEngine.UI.Text>().text = "Connected to " + balance;
    }
}
