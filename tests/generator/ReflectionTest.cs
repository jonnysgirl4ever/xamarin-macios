using System;
using System.Reflection;
using NUnit.Framework;

namespace GeneratorTests {

	public class ReflectionTest {

		protected FieldInfo GetField (string fieldName, Type testType)
		{
			var fieldInfo = testType.GetField (fieldName);
			Assert.NotNull (fieldInfo, "fieldInfo != null");
			return fieldInfo!;
		}

		protected PropertyInfo GetProperty (string propertyName, Type testType)
		{
			var propertyInfo = testType.GetProperty (propertyName);
			Assert.NotNull (propertyInfo, "propertyInto != null");
			return propertyInfo!;
		}

		protected MethodInfo GetMethod (string methodName, Type testType)
		{
			var memberInfo = testType.GetMethod (methodName);
			Assert.NotNull (memberInfo, "memberInfo != null");
			return memberInfo!;
		}
	}
}
