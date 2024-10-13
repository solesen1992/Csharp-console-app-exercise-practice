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
    // Subscriber that is responsible for sending a text message
    public class MessageService
    {
        // Event handler method
        //public void OnVideoEndoced(object source, EventArgs args)
        public void OnVideoEndoced(object source, VideoEventArgs args)
        {
            // Simulating texting scenario
            // Now passes information about the video that we passed with args.Video.Title
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}
