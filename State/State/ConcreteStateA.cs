// See https://aka.ms/new-console-template for more information
using State;

internal class ConcreteStateA : State.State
{
	public override void Handle(Context context)
	{
		context.State = new ConcreteStateB();
	}
}