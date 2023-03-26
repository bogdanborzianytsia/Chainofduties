using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chainofduties;

namespace Chainofduties
{

    public abstract class Handler: Form1
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(string quest, Form1 n);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(string quest, Form1 n)
        {
            
            if (quest == "Hi")
            {
                n.richTextBox2.Text+= "Hi, how can i help you?\n";
            }
            else
            {
                successor.HandleRequest(quest, n);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(string quest, Form1 n)
        {
            if (quest == "Can you help me?")
            {
                n.richTextBox2.Text += "Yes i can help \n";
            }
            else
            {
                successor.HandleRequest(quest, n);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(string quest, Form1 n)
        {
            if (quest == "Can you plus numbers?")
            {
                n.richTextBox2.Text += "Sure i can do it\n";
               
            }
            else
            {
                successor.HandleRequest(quest, n);
            }
        }
    }
    public class ConcreteHandler4 : Handler
    {
        public override void HandleRequest(string quest, Form1 n)
        {
            if (quest == "how much will 8 add to 13?")
            {
                n.richTextBox2.Text += "it will be 21\n";

            }
            else
            {
                n.richTextBox2.Text += "Eror";
            }
        }
    }
}
