using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//sz.sahaj@embracingearth.space

namespace collectibles 
{
    public class IconOpenedCheck : MonoBehaviour
    {
        public bool iconchecked = false;
        [SerializeField] private GameObject UncheckedPopup;
        [SerializeField] private GameObject OpenedCheckTopObject;
        [SerializeField] private Button buttoninteractable;
        
        [SerializeField] private UnityEvent Unopened;
        [SerializeField] private UnityEvent CalledOnopened;
        [SerializeField] private UnityEvent CalledifLocked;
        [SerializeField] private UnityEvent CalledOnUnlocked;

        private Scene m_Scene;
        public Item item;
        private void Start()
        {
             m_Scene = SceneManager.GetActiveScene();
        }

        private void OnEnable()
        {
            LoadState();
        }

        public void LoadState()
        {

            iconchecked = (PlayerPrefs.GetInt(Application.productName + this.gameObject.name) != 0);
            if (iconchecked == false)
            {
                UncheckedPopup.SetActive(true);
                Unopened.Invoke();
            }
            else
            {
                UncheckedPopup.SetActive(false);
                CalledOnopened.Invoke();
            }

            CheckInteractableUnlocked();
        }

        public void CheckInteractableUnlocked()
        {
            if (buttoninteractable.interactable == false)
            {
                CalledifLocked.Invoke();
                if(item!=null)
                    item.gameObject.GetComponent<Item>().Objectlocked_savedState();
            }
            else
            {
                CalledOnUnlocked.Invoke();
                if(item!=null)
                    item.gameObject.GetComponent<Item>().ObjectUnlocked_savedState();
            }

        }

        public void EnableTop() 
        {
            OpenedCheckTopObject.SetActive(true);
            
        }
    
        public void Opened()
        {
            iconchecked = true;
            UncheckedPopup.SetActive(false);
            CalledOnopened.Invoke();
            SaveState();
        }

        void SaveState()
        {
            PlayerPrefs.SetInt(Application.productName + this.gameObject.name, (iconchecked ? 1 : 0));
        }
    }

}
