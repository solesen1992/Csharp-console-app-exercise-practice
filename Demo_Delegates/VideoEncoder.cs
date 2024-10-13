using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * VideoEncoder (Publisher):
 * 
 * This class is responsible for encoding videos. During the encoding process, it raises an event to notify subscribers that a video has been encoded.
 * 
 * Delegate/Event:
 * The event is defined as EventHandler<VideoEventArgs> VideoEncoded, where VideoEventArgs is used to pass information about the video that was encoded.
 * 
 * Encoding Process:
 * The Encode method simulates video encoding by pausing for 3 seconds using Thread.Sleep(3000).
 * After encoding, the method OnVideoEncoded is called, which raises the VideoEncoded event and notifies all subscribers that a video has been encoded.
 */

namespace Demo_DelegatesAndEvents
{
    // Class that contains information about the video that was encoded
    public class VideoEventArgs : EventArgs {
        // Create a property that determines the video that was encoded
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // To do:
        // 1. Define a delegate - The contract within the publisher and subscriber.
        // The signature of the method of the subscriber. It will be called when the publisher publishes an event.
        // 2. Define an event based on that delegate
        // 3. Raise / publish the event

        // 1. Define a delegate
        // Object is the source of the event - or the class that is publishing or sending the event
        // EventArgs is any additional information we want to send with the event
        // public delegate void VideoEncodedEventHandler(object source, EventArgs args); // Before
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2. Define an event based on the delegate.
        // Whenever we raise that, we want a subscriber that confirms to this delegate.
        // public event VideoEncodedEventHandler VideoEncoded;
        // Alternative to the code above:
        public event EventHandler<VideoEventArgs> VideoEncoded; // When we use this, we don't need the code above.

        public void Encode(Video video) {
            Console.WriteLine("Encoding video..");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // 3. Method that is responsible for raising the event.
        // Notify the subscribers
        protected virtual void OnVideoEncoded(Video video)
        {
            // Check if there's any subscribers.
            if (VideoEncoded != null) {
                // We're gonna call the method.
                // The current class is publishing the event: "This" class.
                // Do we want to send any additional data? No. So we use EventArgs.Empty.
                // VideoEncoded(this, EventArgs.Empty); // Before
                // Our publisher will now send additional data which is encapsulated in VideoEventArgs. Which will have reference to the video that was encoded.
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
