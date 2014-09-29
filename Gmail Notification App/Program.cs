using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Johnvey.GmailAgent;

namespace Gmail_Notification_App
{
    class Program
    {
        static void Main(string[] args)
        {
            GmailAdapter gmail = new GmailAdapter();
            GmailSession myAccount = new GmailSession();


           // myAccount.Username = "googler";
            myAccount.Username = "rmh0009@gmail.com";
            myAccount.Password = "01826619";


            GmailAdapter.RequestResponseType loginResult = gmail.Refresh(myAccount);

            Console.WriteLine("here !!!!!!!!!! :(");

            if (loginResult == GmailAdapter.RequestResponseType.Success)
            {
                Console.WriteLine("New Thread : "+myAccount.DefaultSearchCounts["inbox"]);
                
                //if (myAccount.MailboxSize > 0)
                {
                    GmailThread gmaileThread = (GmailThread) myAccount.Threads[0];//UnreadThreads[0];
                    Console.WriteLine("Latest Thread :" + gmaileThread.SubjectHtml);

                }

                //else
                {
                    Console.WriteLine("0-");
                }
            }
            else
            {
                Console.WriteLine("Failed !!!!!!!!!! :(");
            }
            Console.ReadKey();
        }
    }
}
