// See https://aka.ms/new-console-template for more information
internal class ConcreteSubject : Subject
{
	private string subjectState;
	// Gets or sets subject state
	public string SubjectState
	{
		get { return subjectState; }
		set { subjectState = value; }
	}
}