using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace collectibles //sz.sahaj@embracingearth.space
{
    public class OpenClose : MonoBehaviour
    {
        [SerializeField] private GameObject ToEnableDisable;
        public bool state = false;
      
        
        public delegate void ClickAction();
        public static event ClickAction OnClicked;

        [SerializeField] private PanelManager _panelManager;

        public void OpenCloseBasic()
        {
            ToEnableDisable.SetActive(!state);
            if (!state == false)
            {
                OnClicked.Invoke();
            }
        
            state = !state;
        }

        public void OpenBasic()
        {
            ToEnableDisable.SetActive(true);
            state = true;
        }

        private void Start()
        {
            ToEnableDisable.SetActive(state);
        }

        public void OpenCloseItemPanels()
        {
            var tempstate = state;
            OnClicked.Invoke(); //closes all open inventory anels through panel manager
            state = tempstate;
            ToEnableDisable.SetActive(!state);
            state = !state;
        }
    }

}
