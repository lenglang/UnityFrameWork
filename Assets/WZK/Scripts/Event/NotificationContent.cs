using System;
using UnityEngine;
    public class NotificationContent
    {
        /// <summary>
        /// ֪ͨ������
        /// </summary>
        public GameObject sender;

        /// <summary>
        /// ֪ͨ����
        /// ��ע���ڷ�����Ϣʱ��Ҫװ�䡢������Ϣʱ��Ҫ����
        /// ��������һ��������ƣ���Ҫע�⡣
        /// </summary>
        public object param;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="sender">֪ͨ������</param>
        /// <param name="param">֪ͨ����</param>
        public NotificationContent(GameObject sender, object param)
        {
            this.sender = sender;
            this.param = param;
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="param"></param>
        public NotificationContent(object param)
        {
            this.sender = null;
            this.param = param;
        }
        /// <summary>
        /// ʵ��ToString����
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("sender={0},param={1}", this.sender, this.param);
        }
    }