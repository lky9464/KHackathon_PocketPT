using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyStatus : MonoBehaviour
{
    public Text inName;
    public Text inAge;
    public Text inHeight;
    public Text inWeight;
    public Text inDate;
    // Start is called before the first frame update
    
    void Start()
    {
        if(PlayerPrefs.HasKey("Name")){
            inName.text = PlayerPrefs.GetString("Name");
            inAge.text = PlayerPrefs.GetInt("Age").ToString();
            inHeight.text = PlayerPrefs.GetFloat("height").ToString();
            inWeight.text = PlayerPrefs.GetFloat("weight").ToString();
            inDate.text = PlayerPrefs.GetInt("Date").ToString();
        }
    }
}
