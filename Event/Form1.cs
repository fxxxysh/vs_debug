using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    public delegate void _EVENT(Msg msg);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            main_event _event = new main_event();
            TriEvent tri = new TriEvent();

            _event.msg_trans  += tri.Set_text_name;
            _event.test_run(this);

            //实例化对象
            Mom mom = new Mom();
            Dad dad = new Dad();
            Child child = new Child();

            mom.Eat += dad.Eat;
            mom.Eat += child.Eat;
            mom.Cook();
        }
    }

    class main_event
    {
        public event _EVENT msg_trans;
        Msg msg;

        public main_event()
        {
            msg = new Msg();
        }

        public void test_run(object sender)
        {
            msg.val = 123434324;
            msg.sender = sender;
            msg_trans(msg);
        }
    }


    class TriEvent
    {
        public int val = 121;
        public object sender;

        public void Set_text_name(Msg msg)
        {
            val = msg.val;
            sender = msg.sender;
        }
    }


    public class Msg : EventArgs
    {
        public int val = 121;
        public object sender;

        //public Msg(object sender)
        //{
        //    this.sender = sender;
        //}
    }

    public class Mom
    {
        //定义Eat事件，用于发布吃饭消息
        public event Func<int, int> Eat;

        public void Cook()
        {
            //发布消息
            int tt = Eat(3432);
        }
    }

    public class Dad
    {
        public int Eat(int x)
        {
            return 44;
        }
    }

    public class Child
    {
        public int Eat(int x)
        {
            return 33;
        }
    }
}
