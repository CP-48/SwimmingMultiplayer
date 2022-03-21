using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragCard : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Transform parentToreturnTo = null;
   
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToreturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        //Debug.Log("Begin Drag");
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        //Debug.Log("Drag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToreturnTo);
        //Debug.Log("End Drag");
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
