using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apache.NMS.ActiveMQ;
using Apache.NMS;

namespace TestActiveMQ_MNS.Queue
{
    public partial class 生产者1 : Form
    {
        private ConnectionFactory m_factory;
        private IConnection m_connection;
        private ISession m_session;
        private IMessageProducer m_producer;
        public 生产者1()
        {
            InitializeComponent();
            Init();
        }

        private void but_发送_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void Init()
        {
            m_factory = new ConnectionFactory("tcp://127.0.0.1:61616");
            //jms.alwaysSyncSend=false 代表消息非持久化,事务中的消息将使用“异步发送”,持久必定同步发送
            //jms.useAsyncSend=true  代表异步发送，false同步发送
            //m_factory = new ConnectionFactory("tcp://127.0.0.1:61616?....");

            m_connection = m_factory.CreateConnection();
            m_connection.Start();
            m_session = m_connection.CreateSession();

            bool b = m_session.Transacted;
            //自动确认, 确认每一条消息被消费者消费，异步接收时，需要消费者try-catch，避免重复接收消息
            //m_session = m_connection.CreateSession(true,AcknowledgementMode.AutoAcknowledge);
            //手动确认, 确认一个被消费的消息, 将自动确认所有已被会话消费的消息
            //m_session = m_connection.CreateSessionAcknowledgementMode.ClientAcknowledge);
            // 自动批量确认，延迟确认，如果是重复的消息，那么必须把消息头的JMSRedelivered字段设置为true
            //m_session = m_connection.CreateSession(AcknowledgementMode.DupsOkAcknowledge);
        }
        private void SendMessage()
        {
            //创建临时目的地，它们的存在时间只限于创建它们的连接所保持的时间
            //只有创建该临时目的地的连接上的消息消费者才能够从临时目的地中提取消息
            //ITemporaryQueue queue = m_session.CreateTemporaryQueue();

            IQueue queue = m_session.GetQueue("test_Queue");
            m_producer = m_session.CreateProducer(queue);



            //TextMessage消息类型,  普通文本消息
            ITextMessage textMessage = m_producer.CreateTextMessage();
            textMessage.Text = this.txtBox_消息.Text;

            //MapMessafe消息类型,   Map集合消息
            IMapMessage mapMessage = m_producer.CreateMapMessage();
            m_producer.Send(mapMessage);

            //ObjectMessage消息类型, 发送序列化对象
            Queue<string> obj = new Queue<string>();
            obj.Enqueue("one");
            obj.Enqueue("two");
            IObjectMessage objectMessage = m_producer.CreateObjectMessage(obj);
            m_producer.Send(objectMessage);

            //BytesMessage消息类型， 发送字节消息
            IBytesMessage bytesMessage = m_producer.CreateBytesMessage();
            bytesMessage.WriteBytes(System.Text.Encoding.Default.GetBytes("字节"));
            m_producer.Send(bytesMessage);

            //其它消息类型大同小异

            //设置是否持久化
            //m_producer.DeliveryMode= MsgDeliveryMode.Persistent;

            //设置优先级 默认 MsgPriority.BelowNormal 4级
            //m_producer.Priority = MsgPriority.BelowNormal;

            //设置过期时间，5秒后 只有Queue点对点有效
            //m_producer.TimeToLive=new TimeSpan(1000*5);

            //发送超时时间，默认等于0，如果设置超时，则所有的消息都是用同步发送
            //m_producer.RequestTimeout = new TimeSpan(1000*20);

            

        }
    }
}
