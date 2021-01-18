using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public GameObject player;
    public GameObject text1;
    public GameObject text2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            Debug.Log("衝突");
            text1.SetActive(false);
            text2.GetComponent<Text>().text = "到着！";
            text2.SetActive(true);
        }
    }

}
