using UnityEngine;
using System.Collections;

public class SliderTest : MonoBehaviour {


    private UnityEngine.UI.Slider mSlider;

    private void Start()
    {
        mSlider = GetComponent<UnityEngine.UI.Slider>();
    }

    public void Increment(int amount)
    {
        if (mSlider != null)
        {
            mSlider.value += amount;
        }
    }

}
