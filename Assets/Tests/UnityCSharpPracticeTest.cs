using UnityEngine;
using SharpUnit;
using System;

public class MockException : Exception
{
	public MockException()
	{
	}

	public MockException(string message) : base(message)
	{
	}

	public MockException(string message, Exception inner) : base(message)
	{
	}
}

public class UnityCSharpPracticeTest : TestCase
{

	public override void SetUp()
	{
	}

	public override void TearDown()
	{
	}

	[UnitTest]
	public void Test_AssertTrue()
	{
		Assert.True(true);
	}

	[UnitTest]
	public void Test_AssertFalse()
	{
		Assert.False(false);
	}

	[UnitTest]
	public void Test_ThrowExpectError()
	{
		Exception e = new MockException("hoge");
		Assert.ExpectException(e);
		throw e;
	}
}

