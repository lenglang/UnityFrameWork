using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    /// <summary>
    /// �����¼��ַ�ί��
    /// </summary>
public delegate void OnNotification(NotificationContent notific);

    /// <summary>
    ///֪ͨ����
    /// </summary>
    public class NotificationCenter
    {

        /// <summary>
        /// ֪ͨ���ĵ���
        /// </summary>
        private static NotificationCenter instance = null;
        public static NotificationCenter Get()
        {
            if (instance == null)
            {
                instance = new NotificationCenter();
                return instance;
            }
            return instance;
        }
        /// <summary>
        /// �洢�¼����ֵ�
        /// </summary>
        private Dictionary<string, OnNotification> eventListeners
        = new Dictionary<string, OnNotification>();
        /// <summary>
        /// ע���¼�
        /// </summary>
        /// <param name="eventKey">�¼�Key</param>
        /// <param name="eventListener">�¼�������</param>
        public void AddEventListener(string eventKey, OnNotification eventListener)
        {
            if (!eventListeners.ContainsKey(eventKey))
            {
                eventListeners.Add(eventKey, eventListener);
            }
        }

        /// <summary>
        /// �Ƴ��¼�
        /// </summary>
        /// <param name="eventKey">�¼�Key</param>
        public void RemoveEventListener(string eventKey)
        {
            if (!eventListeners.ContainsKey(eventKey))
                return;

            eventListeners[eventKey] = null;
            eventListeners.Remove(eventKey);
        }

        /// <summary>
        /// �ַ��¼�
        /// </summary>
        /// <param name="eventKey">�¼�Key</param>
        /// <param name="notific">֪ͨ</param>
        public void DispatchEvent(string eventKey, NotificationContent notific)
        {
            if (!eventListeners.ContainsKey(eventKey))
                return;
            eventListeners[eventKey](notific);
        }

        /// <summary>
        /// �ַ��¼�
        /// </summary>
        /// <param name="eventKey">�¼�Key</param>
        /// <param name="sender">������</param>
        /// <param name="param">֪ͨ����</param>
        public void DispatchEvent(string eventKey, GameObject sender, object param)
        {
            if (!eventListeners.ContainsKey(eventKey))
                return;
            eventListeners[eventKey](new NotificationContent(sender, param));
        }

        /// <summary>
        /// �ַ��¼�
        /// </summary>
        /// <param name="eventKey">�¼�Key</param>
        /// <param name="param">֪ͨ����</param>
        public void DispatchEvent(string eventKey, object param)
        {
            if (!eventListeners.ContainsKey(eventKey))
                return;
            eventListeners[eventKey](new NotificationContent(param));
        }

        /// <summary>
        /// �Ƿ����ָ���¼��ļ�����
        /// </summary>
        public Boolean HasEventListener(string eventKey)
        {
            return eventListeners.ContainsKey(eventKey);
        }
    }
