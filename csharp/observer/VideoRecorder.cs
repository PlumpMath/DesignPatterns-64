using System;
class VideoRecorder : IObserver
{
	public void Update (string text)
	{
		Console.WriteLine("I am a video recorder capturing the whiteboard {0}", text);
	}
}