using System;
using AxGrid;
using AxGrid.Base;
using SmartFormat;
using UnityEngine;

namespace AppZino.Tools.Binders
{
    /// <summary>
    /// Биндит Model.SmartFormat к полю
    /// </summary>
    [RequireComponent(typeof(UnityEngine.UI.Text))]
    public class UITextDataBind : MonoBehaviourExt
    {
        [Header("События")]
        [Tooltip("Поля при изменении которых будет срабатывать собятие.")]
        public string[] fieldNames = new string[0];
        [Tooltip("Изменение люиого поля модели")]
        public bool modelChanged = true;
        
        [Header("Форматироване")]
        [Tooltip("Smart.Format(format, model)")]
        public string format = "{Balance.Game}";

       
        private UnityEngine.UI.Text uiText;

        [OnAwake]
        void awake()
        {
            try
            {
                uiText = GetComponent<UnityEngine.UI.Text>();
            }
            catch (Exception e)
            {
                Log.Error("Error get Component:{0}", e.Message);
            }
        }
        
        [OnStart]
        public virtual void start()
        {
            try
            {
                if (modelChanged)
                    Settings.Model.EventManager.AddAction("ModelChanged", Changed);
                else
                    foreach (var fieldName in fieldNames)
                        Settings.Model.EventManager.AddAction($"On{fieldName}Changed", Changed);
                Changed();
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        [OnDestroy]
        public void onDestroy()
        {
            try
            {
                if (modelChanged)
                    Settings.Model.EventManager.RemoveAction("ModelChanged", Changed);
                else
                    foreach (var fieldName in fieldNames)
                        Settings.Model.EventManager.RemoveAction($"On{fieldName}Changed", Changed);
            }catch(Exception) {}
        }

        
        protected void Changed()
        {
            uiText.text = Smart.Format(format, Model);
        }
    }
}