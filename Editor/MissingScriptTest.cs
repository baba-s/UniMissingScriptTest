using NUnit.Framework;
using UnityEditor;

namespace Kogane.Internal
{
	internal sealed class MissingScriptTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void Missing_Script_が存在しないか()
		{
			AllGameObjectTester.Test( gameObject => GameObjectUtility.GetMonoBehavioursWithMissingScriptCount( gameObject ) <= 0 );
		}
	}
}