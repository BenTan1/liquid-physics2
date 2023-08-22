using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZibraSlider : MonoBehaviour
{
    public com.zibra.liquid.Solver.ZibraLiquid zibraLiquid;
    public com.zibra.liquid.Manipulators.ZibraLiquidEmitter zibraLiquidEmitter;
    public float value2 = 10f;
    public Slider slider;
    // Start is called before the first frame update
    void Update()
    {
        zibraLiquid.SimulationTimeScale = slider.value;

    }

    

}
