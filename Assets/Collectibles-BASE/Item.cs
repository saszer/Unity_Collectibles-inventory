using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace collectibles
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private Button itemiconbutton;
        [SerializeField] private CollectibleManager _collectibleManager;

        void Update()
        {
            PickupItems();
        }

        void PickupItems()
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Cast a ray from the camera to where you clicked
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                // If the raycast hit something..
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    if (hit.collider.gameObject == this.gameObject)
                    {
                        itemiconbutton.interactable = true;
                        itemiconbutton.GetComponent<OpenClose>()
                            .OpenCloseItemPanels(); //Open item description Panel
                        _collectibleManager.UpdateItemsCollectedListFromGame(); // Update the state in list to save
                    }

                }
            }
        }
    }
}