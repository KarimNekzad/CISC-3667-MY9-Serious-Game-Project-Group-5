using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject DisplayTooltip;
    public GameObject TooltipObject;
    // Start is called before the first frame update
    void Start()
    {
        DisplayTooltip.SetActive(false);
        DontDestroyOnLoad(TooltipObject);
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        DisplayTooltip.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DisplayTooltip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver() {
        DisplayTooltip.SetActive(true);
        Debug.Log("Mouse is over GameObject.");
    }

    public void OnMouseExit()
    {
        DisplayTooltip.SetActive(false);
    }
}
