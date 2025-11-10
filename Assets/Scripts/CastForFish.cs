using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;

public class FishingCast : MonoBehaviour
{
    public float CastRange = 100f;
    public float CastSpeed = 20f;
    public bool IsCasting = false;
    public object rod;
    InputAction ClickAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClickAction = InputSystem.actions.FindAction("LeftClick");



        
    }

    // Update is called once per frame
    void Update()
    {
        if (ClickAction.IsPressed())
        {
            IsCasting = true;
        }
        else
        {
            IsCasting = false;
        }

        if (IsCasting)
        {

        }



    }
}
