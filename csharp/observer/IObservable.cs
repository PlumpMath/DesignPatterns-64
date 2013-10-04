public interface IObservable 
{
	void Attach (IObserver observer);
	void Detach (IObserver observer);
	void Update(string text);
}