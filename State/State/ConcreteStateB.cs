// See https://aka.ms/new-console-template for more information
using State;

internal class ConcreteStateB : State.State
{
	public override void Handle(Context context)
	{
		context.State = new ConcreteStateA();
	}
}