using System;

public class OctopusCountdown : IEnumerator
{
	private int count;

	public OctopusCountdown(Octopus o)
	{
		// Count down from # of legs on octopus
		count = o.Legs + 1;
	}

	public bool MoveNext() => count-- > 0;

	public object Current => count;

	public void Reset()
	{
		throw new NotSupportedException();
	}
}
