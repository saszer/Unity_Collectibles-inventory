using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace collectibles //sz.sahaj@embracingearth.space
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private Button itemiconbutton;
        [SerializeField] private CollectibleManager _collectibleManager;

        [SerializeField] IconOpenedCheck _iconOpenedCheck;

        [SerializeField] private UnityEvent OnGameObjectpicked;
        private void Awake()
        {
            itemiconbutton.GetComponent<IconOpenedCheck>().item = this;
        }

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
                        itemiconbutton.interactable = true; //unlocked
                        
                        //Auto Open item description Panel on click 
                        itemiconbutton.GetComponent<OpenClose>()
                            .OpenCloseItemPanels(); 
                        
                        
                        _collectibleManager.UpdateItemsCollectedList(); // Update the state in list to save
                        _collectibleManager.OnAnyCollectibleClicked.Invoke();

                        ObjectPicked();
                    }

                }
            }
        }

        public void ObjectPicked()
        {
            GetComponent<MeshRenderer>().enabled = false;; 
            OnGameObjectpicked.Invoke();
        }
    }
}