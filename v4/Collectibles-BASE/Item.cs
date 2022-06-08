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

        [SerializeField] IconOpenedCheck _iconOpenedCheck;

        [SerializeField] private UnityEvent OnGameObjectpicked;
        
        [SerializeField] private UnityEvent ObjectUnlocked_SavedState;
        [SerializeField] private UnityEvent Objectlocked_SavedStateL;

        [Header("Set on collectible and icon, works across scenes")]
        public string collectiblename;
        private GameObject _ItemGroup;
        

        private void Start()
        {
            ////scene cross compatibility 
            _ItemGroup = CollectibleManager.Instance.ItemGroup;
           foreach (Transform t in _ItemGroup.transform)
            {
                if (t.GetComponent<Inbetweenscenelinker>().collectiblename == collectiblename)
                {
                    itemiconbutton = t.GetComponent<Button>();
                    break;
                }
            }
            ///////////////////////////////

            var ioc = itemiconbutton.GetComponent<IconOpenedCheck>();
            ioc.item = this;
            ioc.CheckInteractableUnlocked(); //added for cross scene
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
                       // itemiconbutton.GetComponent<OpenClose>()
                       //     .OpenCloseItemPanels(); 
                        
                        
                        CollectibleManager.Instance.UpdateItemsCollectedList(); // Update the state in list to save
                        CollectibleManager.Instance.OnAnyCollectibleClicked.Invoke();

                        ObjectPicked();
                    }

                }
            }
        }

        public void ObjectPicked()
        {
           // GetComponent<MeshRenderer>().enabled = false;; 
            OnGameObjectpicked.Invoke();
        }

        public void ObjectUnlocked_savedState()
        {
           // GetComponent<MeshRenderer>().enabled = false;; 
            ObjectUnlocked_SavedState.Invoke();
        }
        public void Objectlocked_savedState()
        {
         //  GetComponent<MeshRenderer>().enabled = true;; 
            Objectlocked_SavedStateL.Invoke();
        }
        
    }
}