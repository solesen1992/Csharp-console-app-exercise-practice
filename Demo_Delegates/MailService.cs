using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Subscribers:
 * MailService and MessageService are two subscriber classes. They subscribe to the VideoEncoded event from the VideoEncoder class.
 * 
 * Both services have event handler methods (OnVideoEncoded and OnVideoEndoced, respectively) that define what happens when the event is raised:
 * MailService sends an email.
 * MessageService sends a text message.
 */

namespace Demo_DelegatesAndEvents
{
    // Creating subscribers
    public class MailService
    {
        // public void OnVideoEncoded(object source, EventArgs eventArgs) // Before
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            // Simulate to send an mail
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}
