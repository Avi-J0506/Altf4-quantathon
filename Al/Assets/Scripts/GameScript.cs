using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using System.Threading.Tasks;


public class GameScript : MonoBehaviour
{
    public GameObject claimNFT;
    private ThirdwebSDK thirdwebSDK;
    public Prefab_NFT prefab_NFT;
    public Contract contract;
    string address;

    // Start is called before the first frame update
    void Start()
    {
        thirdwebSDK = new ThirdwebSDK("goerli");

        address = PlayerPrefs.GetString("address");

        contract = thirdwebSDK.GetContract(address);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void getNFTMedia()
    {

        claimNFT.SetActive(true);
        NFT nft = await contract.ERC1155.Get("0");
        Prefab_NFT nftPrefabScript = prefab_NFT.GetComponent<Prefab_NFT>();
        nftPrefabScript.LoadNFT(nft);
    }

}
