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
    public partial class 消费者1 : Form
    {

        private IConnectionFactory m_factory;
        private IConnection m_connection;
        private ISession m_session;
        private IMessageConsumer m_consumer;
        public 消费者1()
        {
            InitializeComponent();
        }

        private void 消费者1_Load(object sender, EventArgs e)
        {
            
        }

        private void Init()
        {
            m_factory = new ConnectionFactory("tcp://127.0.0.1,61616");
            m_connection = m_factory.CreateConnection();
            m_session = m_connection.CreateSession();
        }

        private void GetMessage()
        {
            IQueue queue = m_session.GetQueue("test_Queue");
            m_consumer = m_session.CreateConsumer(queue);
            //根据队列消息，强转为指定格式的消息类型
            ITextMessage textMessage = (ITextMessage)m_consumer.Receive();

            //同步阻塞，等待指定时间接收下一条消息
            //ITextMessage textMessage = (ITextMessage)m_consumer.Receive(new TimeSpan(1000*5));

            //异步消费
            m_consumer.Listener += new MessageListener();


        }
            private void Listener(IMessage Message)
            {
                
            }
    }
}
