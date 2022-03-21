using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    public DragCard objectDrag;

    public void OnPointerEnter(PointerEventData eventData)
    {
        objectDrag.transform.SetParent(objectDrag.transform.parent);
    }

    public void OnDrop(PointerEventData eventData)
    {
        objectDrag.transform.position = eventData.position;
        Debug.Log("Drop");
    }

    public void OnPointerExit(PointerEventData eventData)
    {

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
