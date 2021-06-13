using UnityEngine;
using UnityEngine.UI;



public class NumberDisplay : MonoBehaviour
{
    Text sliderValue;
    // Start is called before the first frame update
    void Start()
    {
        sliderValue = GetComponent<Text> (); 
    }

    // Update is called once per frame
    public void textUpdate (float value)
    {
        sliderValue.text = value.ToString();
    }
}
