using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace AsmJit.Common
{
	internal static class DelegateCreator
	{
		private static readonly Func<Type[], Type> MakeNewCustomDelegate = (Func<Type[], Type>) Delegate.CreateDelegate(typeof(Func<Type[], Type>), typeof(Expression).Assembly.GetType("System.Linq.Expressions.Compiler.DelegateHelpers").GetMethod("MakeNewCustomDelegate", BindingFlags.NonPublic | BindingFlags.Static));

		public static Type NewDelegateType(Type[] parameters = null)
		{
			Type[] args = null;
			if (parameters != null && parameters.Length > 0)
			{
				args = new Type[parameters.Length + 1];
				parameters.CopyTo(args, 0);
			}
			if (args == null)
			{
				args = new Type[] {null};
			}
			else
			{
				args[args.Length - 1] = null;
			}
			return MakeNewCustomDelegate(args);
		}

		public static Type NewDelegateType(Type ret, Type[] parameters = null)
		{
			if (!(ret != null))
			{
				throw new ArgumentException();
			}
			Type[] args;
			if (parameters == null || parameters.Length == 0)
			{
				args = new[] {ret};
			}
			else
			{
				args = new Type[parameters.Length + 1];
				parameters.CopyTo(args, 0);
				args[args.Length - 1] = ret;
			}
			return MakeNewCustomDelegate(args);
		}

		private static MethodInfo MethodInfoFromDelegateType(Type delegateType)
		{
			return delegateType.GetMethod("Invoke");
		}

		public static T CreateCompatibleDelegate<T>(object instance, MethodInfo method)
		{
			var delegateInfo = MethodInfoFromDelegateType(typeof(T));

			var methodTypes = method.GetParameters().Select(m => m.ParameterType);
			var delegateTypes = delegateInfo.GetParameters().Select(d => d.ParameterType);

			// Convert the arguments from the delegate argument type
			// to the method argument type when necessary.
			var arguments = methodTypes.Zip(delegateTypes, (methodType, delegateType) =>
			{
				var delegateArgument = Expression.Parameter(delegateType);
				return new
				{
					DelegateArgument = delegateArgument,
					ConvertedArgument = methodType != delegateType
						? (Expression) Expression.Convert(delegateArgument, methodType)
						: delegateArgument
				};
			}).ToArray();

			// Create method call.;
			var methodCall = Expression.Call(instance == null ? null : Expression.Constant(instance), method, arguments.Select(a => a.ConvertedArgument));

			// Convert return type when necessary.
			var convertedMethodCall = delegateInfo.ReturnType == method.ReturnType
				? (Expression) methodCall
				: Expression.Convert(methodCall, delegateInfo.ReturnType);

			return Expression.Lambda<T>(convertedMethodCall, arguments.Select(a => a.DelegateArgument)).Compile();
		}
	}
}
