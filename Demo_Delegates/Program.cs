using Demo_DelegatesAndEvents;
using System.Reflection;

/*
 * CREDIT: Code along session. 
 * Code is made by: https://www.youtube.com/watch?v=jQgwEsJISy0
 * This code demonstrates the use of delegates and events to create a simple publisher-subscriber communication model. 
 * The key concept here is how different components interact in a loosely coupled manner.
 * 
 * Delegates define a function signature and act as a contract between publishers and subscribers.
 * 
 * Events provide a way for the publisher (VideoEncoder) to notify subscribers (MailService, MessageService) 
 * when something happens (in this case, when a video is encoded).
 * 
 * This pattern allows the system to be loosely coupled, where the publisher doesn't need to know the details 
 * of the subscribers, and new subscribers can be added without changing the existing code.
 * 
 * Publisher-Subscriber Setup:
 * In the Main method of the Program class, a VideoEncoder object (the publisher) is created.
 * The MailService and MessageService subscribe to the VideoEncoded event by adding their event handler 
 * methods (OnVideoEncoded and OnVideoEndoced) to the event.
 * 
 * Raising the Event:
 * When videoEncoder.Encode(video) is called, it triggers the encoding process.
 * After encoding is completed, the OnVideoEncoded method in VideoEncoder checks for subscribers and 
 * raises the VideoEncoded event.
 * Both MailService and MessageService are notified and execute their respective event handlers, 
 * simulating sending an email and a text message about the encoded video.
 * 
 * Notes: 
 * Delegates allows you to store a function in a variable.
 * Delegates are defined as function signature and return type without implementation.
 * Delegates are also the agreement / constract between Publisher and Subscriber.
 * Determines the signature of the event handler method in Subscriber.
 * 
 * Events is a mechanism for communiation between objects.
 * Used to build loosely coupled applications.
 */

namespace Demo_DelegatesAndEvents
{
    class Program {
        static void Main(string[] args) {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Subscriber
            var messageService = new MessageService(); // Subscriber

            // Only uses the name of the method. So it's a reference to that method.
            // VideoEncoded is a list of pointers to methods.
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.VideoEncoded += messageService.OnVideoEndoced;

            // Calling the encode method passing the video object
            videoEncoder.Encode(video);
        }
    }
}