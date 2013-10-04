using System;
class Observer
{
	public static void Main() 
	{
		var whiteBoard = new WhiteBoard();
		var student = new Student();
		var videoRecorder = new VideoRecorder();

		whiteBoard.Attach(student);
		//only student will be updated with this.
		whiteBoard.Update("Class started");

		//attach the video recorder.
		whiteBoard.Attach(videoRecorder);

		//both student and video recorder will receive this update/
		whiteBoard.Update("Date is 2013 ect..");
		whiteBoard.Detach(student);

		//only video recorder will receive this update.
		whiteBoard.Update("Class ended.");
	}
}