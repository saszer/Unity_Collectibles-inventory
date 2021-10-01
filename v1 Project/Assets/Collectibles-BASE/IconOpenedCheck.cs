using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
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
           // LoadState();
        }

        public void LoadState()
        {

            iconchecked = (PlayerPrefs.GetInt(Application.productName+m_Scene.name + this.gameObject.name) != 0);
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

        void CheckInteractableUnlocked()
        {
            if (buttoninteractable.interactable == false)
            {
                CalledifLocked.Invoke();
                item.gameObject.GetComponent<MeshRenderer>().enabled = true;
            }
            else
            {
                CalledOnUnlocked.Invoke();
                item.gameObject.GetComponent<MeshRenderer>().enabled = false;; //to disable gameobject if already picked
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
            PlayerPrefs.SetInt(Application.productName+m_Scene.name + this.gameObject.name, (iconchecked ? 1 : 0));
        }
    }

}
